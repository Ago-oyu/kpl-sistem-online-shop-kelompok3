using System.Data;
using System.Data.SQLite;
using System.Text.Json;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api")]
    public class BackendController : ControllerBase
    {
        readonly Database database = new();
        const string tableName = "product";
        Dictionary<string, string> tableMapping = new(){
            {"produk", "produk"},
            {"user", "user"},
            {"keranjang", "keranjang"},
            {"product", "product"}
        };
        public enum Types {
            produk, user, keranjang
        }
        [HttpGet("getProductPage")]
        public IEnumerable<Product> Get([FromQuery] string? page=null, [FromQuery] int batch=20)
        {
            using var cn = database.GetCn();

            var query = $"select * from {tableName} ";
            // kalau page null return semua
            if (page is not null)
            {
                query+= $"limit {batch} offset ({page} - 1) * {batch}";
            }

            return cn.Query<Product>(query);
        }
        /// <summary>
        /// type bisa berisi produk, user, atau keranjang
        /// </summary>
        [HttpGet("{type}/{id}")]
        public Product GetOne([FromRoute] Types type, [FromRoute] string id)
        {
            using IDbConnection cn = database.GetCn();
            var result = cn.Query<Product>($"select * from {tableMapping[type.ToString()]} where id={id};").ToList();
            if (result.Count == 0){
                return null;
            }
            return result[0];
        }
        [HttpPost("{type}")]
        public void Post([FromRoute] Types type, [FromBody] Product input)
        {
            using IDbConnection cn = database.GetCn();
            // implement class input mapper
            cn.QueryAsync($"insert into {tableName} (name, stock) values ('{input.name}', {input.stock});");
        }

        [HttpDelete("{type}/{id}")]
        public void Delete([FromRoute] Types type, [FromRoute] string id)
        {
            using IDbConnection cn = database.GetCn();
            cn.QueryAsync($"delete from {tableMapping[type.ToString()]} where id={id};");
        }
    }
}
