using System.Data;
using System.Data.SQLite;
using System.Text.Json;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        readonly Database database = new();
        const string tableName = "product";

        [HttpGet("getPage")]
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
        [HttpGet("getProduct")]
        public Product GetOne([FromQuery] string id)
        {
            using IDbConnection cn = database.GetCn();
            var result = cn.Query<Product>($"select * from {tableName} where id={id};").ToList();
            if (result.Count == 0){
                return null;
            }
            return result[0];
        }
        [HttpPost(Name = "PostProduct")]
        public void Post([FromBody] Product input)
        {
            using IDbConnection cn = database.GetCn();
            cn.QueryAsync($"insert into {tableName} (name, stock) values ('{input.name}', {input.stock});");
        }

        [HttpDelete(Name = "DeleteProduct")]
        public void Delete([FromQuery] string id)
        {
            using IDbConnection cn = database.GetCn();
            cn.QueryAsync($"delete from {tableName} where id={id};");
        }
    }
}
