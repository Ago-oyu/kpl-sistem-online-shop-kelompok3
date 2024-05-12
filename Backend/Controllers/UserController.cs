using System.Data;
using System.Data.SQLite;
using System.Text.Json;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        readonly Database database = new();
        const string tableName = "user";

        [HttpGet(Name = "GetUser")]
        public User Get([FromQuery] string id)
        {
            using var cn = database.GetCn();
            var query = $"select * from {tableName} where id='{id}'";

            var res = cn.Query<User>(query).ToList();
            if (res.Count == 0)
                return null;
                
            return res[0];
        }

        [HttpPost(Name = "PostUser")]
        public void Post([FromBody] User input)
        {
            using IDbConnection cn = database.GetCn();
            cn.QueryAsync($"insert into {tableName} (name, phone_number) values ('{input.name}', '{input.phoneNumber}');");
        }

        [HttpDelete(Name = "DeleteUser")]
        public void Delete([FromQuery] string id)
        {
            using IDbConnection cn = database.GetCn();
            cn.QueryAsync($"delete from {tableName} where id={id};");
        }
    }
}
