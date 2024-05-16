using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SQLite;
using System.Linq.Expressions;
using System.Text.Json;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api")]
    public class BackendController : ControllerBase
    {
        readonly Database database = new();
        Dictionary<string, string> tableMapping = new(){
            {"produk", "product"},
            {"user", "user"},
            // {"keranjang", "keranjang"},
            // {"product", "product"}
        };
        public enum Types {
            produk, user, keranjang
        }
        [HttpGet("getProductPage")]
        public IEnumerable<Product> Get([FromQuery] string? page=null, [FromQuery] int batch=20)
        {
            using var db = new Database();

            var query = $"select * from {tableMapping[Types.produk.ToString()]} ";

            // kalau page null return semua
            if (page is not null)
            {
                query+= $"limit {batch} offset ({page} - 1) * {batch}";
            }
            
            return db.Database.SqlQueryRaw<Product>(query).ToList();;
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
                    result = db.product.AsEnumerable().FirstOrDefault(i => i.id == id);
                    break;
                case Types.user:
                    // result = db.user.AsEnumerable().FirstOrDefault(i => i.id == id);
                    return JsonSerializer.Serialize(db.user.AsEnumerable().FirstOrDefault(i => i.id == id));
                    break;
                default:
                    return "";
            }

            if (result is null)
                return "";

            return JsonSerializer.Serialize(result);
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
                        operationDone = updater.Execute<Product>(input);
                        break;
                    case Types.user:
                        operationDone = updater.Execute<User>(input);
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

            // if (operationDone == DatabaseUpdater.Result.inserted)
            // {
            //     return new Dictionary<string, string>{{"status", "completed data ter insert"}};
            // } else
            // {
            //     return new Dictionary<string, string>{{"status", "completed data ter update"}};
            // }

            // if (valid)
            // {
            //     return new Dictionary<string, string>{{"status", "completed"}};
            // } else 
            // {
            //     if (insert)
            //     {
            //         return new Dictionary<string, string>{{"status", $"failed"}, {"reason", "primary key data sudah ada"}};
            //     } else
            //     {
            //         return new Dictionary<string, string>{{"status", $"failed"}, {"reason", "primary key data belum ada (set query param insert ke true)"}};
            //     }
            // }
        }

        [HttpPost("dl")]
        public void rmid([FromBody] string input)
        {
            using var db = new Database();

            var updated = false;
            foreach (User user in db.user.ToList())
            {
                // if (user.ids.Contains(input))
                // {
                //     updated = true;
                //     user.ids.Remove(input);
                // }
            }
            
            if (updated)
                db.SaveChanges();
        }

        [HttpDelete("{type}/{id}")]
        public void Delete([FromRoute] Types type, [FromRoute] string id)
        {
            using var db = new Database();
            db.Database.ExecuteSqlRaw($"delete from {tableMapping[type.ToString()]} where id='{id}';");
            db.SaveChanges();
        }
    }
}
