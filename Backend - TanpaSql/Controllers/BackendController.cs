using System.Data;
using System.Data.SQLite;
using System.Linq.Expressions;
using System.Text.Json;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api")]
    public class BackendController : ControllerBase
    {
/*        readonly Database database = new();
*/        Dictionary<string, string> tableMapping = new(){
            {"produk", "product"},
            {"user", "user"},
            // {"keranjang", "keranjang"},
            // {"product", "product"}
        };
        public enum Types {
            produk, user, keranjang
        }
        [HttpGet("getProductPage")]
        public List<String> Get([FromQuery] string? page=null, [FromQuery] int batch=20)
        {
            /*            using var db = new Database();

                        var query = $"select * from {tableMapping[Types.produk.ToString()]} ";

                        // kalau page null return semua
                        if (page is not null)
                        {
                            query+= $"limit {batch} offset ({page} - 1) * {batch}";
                        }

                        return db.Database.SqlQueryRaw<Product>(query).ToList();;
            */
            return new List<String> { "1"};
        }
        /// <summary>
        /// type bisa berisi produk, user, atau keranjang
        /// </summary>
        [HttpGet("{type}/{id}")]
        public string GetOne([FromRoute] Types type, [FromRoute] string id)
        {
            /*            using var db = new Database();
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

            */
            return "";
        }

/*        [HttpPost("produk")]
        public Dictionary<string, string> PostProduct([FromBody] Product input)
        {
            using var db = new Database();

            // kalau sudah ada update
            Product row = db.product.AsEnumerable().FirstOrDefault(rw => rw.id == input.id, null);
            if (row is not null)
            {
                db.Entry(row).CurrentValues.SetValues(input);
                db.SaveChanges();
                return new Dictionary<string, string> { { "status", "row updated" } };
            }

            // set id dengan guid random
            string guid = Database.CreateGUID();
            input.id = guid;

            db.product.Add(input);
            db.SaveChanges();

            return new Dictionary<string, string> { { "createdGuid", guid } };


        }
*/        
/*        [HttpPost("user")]
        public Dictionary<string, string> PostUser([FromBody] User input)
        {
            using var db = new Database();

            // kalau data sudah ada update
            var row = db.user.AsEnumerable().FirstOrDefault(i => i.id == input.id, null);
            if (row is not null)
            {
                db.Entry(row).CurrentValues.SetValues(input);
                db.SaveChanges();
                return new Dictionary<string, string> { { "status", "row updated" } };
            }

            // set id dengan guid random
            string guid = Database.CreateGUID();
            input.id = guid;

            db.user.Add(input);
            db.SaveChanges();

            return new Dictionary<string, string> { { "createdGuid", guid } };

        }
*/
        [HttpDelete("{type}/{id}")]
        public void Delete([FromRoute] Types type, [FromRoute] string id)
        {
/*            using var db = new Database();
            db.Database.ExecuteSqlRaw($"delete from {tableMapping[type.ToString()]} where id='{id}';");
            db.SaveChanges();
*/        
        }
    }
}
