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
            produk, pembeli, penjual, keranjang
        }
        [HttpGet("getProductPage")]
        public IEnumerable<Produk> Get([FromQuery] string? page=null, [FromQuery] int batch=20)
        {
            using var db = new Database();

            var query = $"select * from produk";

            // kalau page null return semua
            if (page is not null)
            {
                query+= $"limit {batch} offset ({page} - 1) * {batch}";
            }
            
            return db.Database.SqlQueryRaw<Produk>(query).ToList();;
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
            try {
                switch (type)
                {
                    case Types.produk:
                        operationDone = updater.Execute<Produk>(input);
                        break;
                    case Types.pembeli:
                        operationDone = updater.Execute<Pembeli>(input);
                        break;
                    case Types.penjual:
                        operationDone = updater.Execute<Penjual>(input);
                        break;
                    case Types.keranjang:
                        operationDone = updater.Execute<Keranjang>(input);
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
            } else
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
