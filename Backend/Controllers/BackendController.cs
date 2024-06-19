using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SQLite;
using System.Linq.Expressions;
using System.Text.Json;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using DataTypes;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api")]
    public class BackendController : ControllerBase
    {
        readonly Database database = new();
        // Dictionary<string, string> tableMapping = new(){
        //     {"produk", "product"},
        //     {"user", "user"},
        //     // {"keranjang", "keranjang"},
        //     // {"product", "product"}
        // };
        public enum Types {
            produk, pembeli, penjual, keranjang, pesanan
        }
        [HttpGet("getProductPage")]
        public string Get([FromQuery] int? page=null, [FromQuery] int batch=20, [FromQuery] Produk.Sorting? sort=Produk.Sorting.none, 
            [FromQuery] Produk.SortDir? dir=Produk.SortDir.asc, [FromQuery] string namaContain="")
        {
            using var db = new Database();

            var query = db.produk.Where(prd => true).AsEnumerable();
            
            if (namaContain != "")
                query = query.Where(prd => prd.Nama.Contains(namaContain));

            bool sorted = true;
            switch (sort)
            {
                case Produk.Sorting.random:
                    query = query.OrderBy(prd => Guid.NewGuid());
                    break;
                case Produk.Sorting.harga:
                    query = query.OrderBy(prd => prd.Harga);
                    break;
                default:
                    sorted = false;
                    break;
            }

            if (sorted && dir == Produk.SortDir.desc)
                query = query.Reverse();

            // kalau page null return semua
            if (page is not null && page > 0)
            {
                query = query.Skip((page?? - 1) * batch).Take(batch);
            }

            return JsonSerializer.Serialize(query.ToList());
        }

        [HttpPost("login")]
        public string LoginMethod([FromBody] LoginInfo data)
        {
            using var db = new Database();
            LoginOut<dynamic> res = new();

            if (data.Type == UserTypes.pembeli)
            {
                res.Info = db.pembeli.AsEnumerable().FirstOrDefault(i => i.Email == data.Email);
            } else 
            {
                res.Info = db.penjual.AsEnumerable().FirstOrDefault(i => i.Email == data.Email);
            }

            if (res.Info == null)
            {
                res.Status = "user tidak ditemukan";
            } else if (!PasswordHandler.CheckPassword(data.Password, res.Info.Salt, res.Info.Password))
            {
                res.Status = "password salah";
                res.Info = null;
            } else {
                res.Status = "sukses";
                res.Info.Password = data.Password; // set password plainText agar bisa update data
                res.Info.Salt = null; // set password plainText agar bisa update data
            }

            return JsonSerializer.Serialize(res);
        }

        [HttpPost("register/{type}")]
        public string Register([FromBody] JsonElement data, [FromRoute] UserTypes type)
        {
            using var db = new Database();
            dynamic res;
            dynamic existingEmail; // antara tipe Pembeli atau Penjual
            dynamic existingId; // antara tipe Pembeli atau Penjual

            if (type == UserTypes.pembeli)
            {
                res = JsonSerializer.Deserialize<Pembeli>(data);
                existingEmail = db.pembeli.AsEnumerable().FirstOrDefault(i => i.Email == res.Email);
                existingId = db.pembeli.AsEnumerable().FirstOrDefault(i => i.Id == res.Id);
            } else 
            {
                res = JsonSerializer.Deserialize<Penjual>(data);
                existingEmail = db.penjual.AsEnumerable().FirstOrDefault(i => i.Email == res.Email);
                existingId = db.penjual.AsEnumerable().FirstOrDefault(i => i.Id == res.Id);
            }

            if (existingEmail != null)
            {
                return "email sudah terpakai";
            } else if (existingId != null)
            {
                return "id sudah terpakai";
            } else
            {
                var updater = new DatabaseUpdater(db);
                if (type == UserTypes.pembeli)
                    updater.InsertUser<Pembeli>(data);
                else
                    updater.InsertUser<Penjual>(data);
                
                return "register sukses";
            }
        }

        /// <summary>
        /// type bisa berisi produk, user, atau keranjang
        /// </summary>
        [HttpGet("{type}/{id}")]
        public string GetOne([FromRoute] Types type, [FromRoute] string id)
        {
            using var db = new Database();
            dynamic result; 

            switch (type)
            {
                case Types.produk:
                    return JsonSerializer.Serialize(db.produk.AsEnumerable().FirstOrDefault(i => i.Id == id));
                case Types.pembeli:
                     return JsonSerializer.Serialize(db.pembeli.AsEnumerable().FirstOrDefault(i => i.Id == id));
                case Types.penjual:
                     return JsonSerializer.Serialize(db.penjual.AsEnumerable().FirstOrDefault(i => i.Id == id));
                case Types.keranjang:
                    return JsonSerializer.Serialize(db.keranjang.AsEnumerable().FirstOrDefault(i => i.Id == id));
                case Types.pesanan:
                    return JsonSerializer.Serialize(db.pesanan.AsEnumerable().FirstOrDefault(i => i.Id == id)?.PullDependency(db));
                default:
                    return "";
            }
        }
        [HttpGet("{type}/many")]
        public string GetMany([FromRoute] Types type)
        {
            using var db = new Database();
            dynamic result; 

            switch (type)
            {
                // case Types.produk:
                //     return JsonSerializer.Serialize(db.produk.AsEnumerable().FirstOrDefault(i => i.Id == id));
                // case Types.pembeli:
                //      return JsonSerializer.Serialize(db.pembeli.AsEnumerable().FirstOrDefault(i => i.Id == id));
                // case Types.penjual:
                //      return JsonSerializer.Serialize(db.penjual.AsEnumerable().FirstOrDefault(i => i.Id == id));
                // case Types.keranjang:
                //     return JsonSerializer.Serialize(db.keranjang.AsEnumerable().FirstOrDefault(i => i.Id == id));
                case Types.pesanan:
                    List<Pesanan> pesanans = db.pesanan.ToList();
                    pesanans.ForEach(i => i.PullDependency(db));
                    return JsonSerializer.Serialize(pesanans);
                default:
                    return "";
            }
        }
        [HttpPost("{type}")]
        public ContentResult PostAny([FromRoute] Types type, [FromBody] JsonElement input)
        {
            using var db = new Database();
            var updater = new DatabaseUpdater(db);
            var operationDone = DatabaseUpdater.Result.inserted;

            if (type == Types.pembeli || type == Types.penjual)
            {
                dynamic row = type == Types.pembeli ? updater.GetRow<Pembeli>(input) : updater.GetRow<Penjual>(input);
                if (row == null)
                    return new ContentResult() { Content = "hanya boleh update data untuk tipe penjual dan pembeli, gunakan register untuk menabah entry baru", StatusCode = 400 };
                else if (!PasswordHandler.CheckPassword(input.GetProperty("Password").GetString(), row.Salt, row.Password)) 
                    return new ContentResult() { Content = "update gagal password salah", StatusCode = 400 };
            }

            try
            {
                switch (type)
                {
                    case Types.produk:
                        operationDone = updater.Execute<Produk>(input);
                        break;
                    case Types.pembeli:
                        updater.UpdateUser<Pembeli>(input);
                        operationDone = DatabaseUpdater.Result.updated;
                        break;
                    case Types.penjual:
                        updater.UpdateUser<Penjual>(input);
                        operationDone = DatabaseUpdater.Result.updated;
                        break;
                    case Types.keranjang:
                        operationDone = updater.Execute<Keranjang>(input);
                        break;
                    case Types.pesanan:
                        operationDone = updater.Execute<Pesanan>(input);
                        break;
                }
            } catch (Exception ex)
            {
                // return new ContentResult() { Content = ex.Message, StatusCode = 500 };
                throw;
            }

            if (operationDone == DatabaseUpdater.Result.inserted)
            {
                return new ContentResult() { Content = "completed, data ter insert", StatusCode = 200 };
            }
            else
            {
                return new ContentResult() { Content = "completed, data ter update", StatusCode = 200 };
            }
        }
        [HttpDelete("{type}/{id}")]
        public void Delete([FromRoute] Types type, [FromRoute] string id)
        {
            using var db = new Database();
            db.Database.ExecuteSqlRaw($"delete from {type.ToString()} where id='{id}';");
            db.SaveChanges();
        }
    }
}
