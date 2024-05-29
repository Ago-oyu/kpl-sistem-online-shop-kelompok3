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
        public List<String> Get([FromQuery] string? page=null, [FromQuery] int batch=20)
        {
            /*            using var cn = database.GetCn();

                        var query = $"select * from {tableName} ";
                        // kalau page null return semua
                        if (page is not null)
                        {
                            query+= $"limit {batch} offset ({page} - 1) * {batch}";
                        }

                        return cn.Query<Product>(query);
            */
            return new List<string> { };
        }
        [HttpGet("getProduct")]
        public string GetOne([FromQuery] string id)
        {
            /*            using IDbConnection cn = database.GetCn();
                        var result = cn.Query<Product>($"select * from {tableName} where id='{id}';").ToList();
                        if (result.Count == 0){
                            return null;
                        }
                        return result[0];
            */
            return "";
        }
        [HttpPost(Name = "PostProduct")]
        public /*Dictionary<string, string>*/ String Post([FromBody] Product input)
        {
            /*            string guid = Database.CreateGUID();

                        using IDbConnection cn = database.GetCn();
                        cn.QueryAsync($"insert into {tableName} (id, name, stock) values ('{guid}', '{input.name}', {input.stock});");

                        return new Dictionary<string, string> { { "productGuid", guid } };
            */
            return input.id;
        }

        [HttpDelete(Name = "DeleteProduct")]
        public void Delete([FromQuery] string id)
        {
/*            using IDbConnection cn = database.GetCn();
            cn.QueryAsync($"delete from {tableName} where id='{id}';");
*/        
        }
    }
}
