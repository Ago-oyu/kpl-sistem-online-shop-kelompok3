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
/*        readonly Database database = new();
*/        const string tableName = "user";

        [HttpGet(Name = "GetUser")]
        public /*User*/ string Get([FromQuery] string id)
        {
            /*            using var cn = database.GetCn();
                        var query = $"select * from {tableName} where id='{id}'";

                        var res = cn.Query<User>(query).ToList();
                        if (res.Count == 0)
                            return null;

                        return res[0];
            */
            return "";
        }

/*        [HttpPost(Name = "PostUser")]
        public Dictionary<string, string> Post([FromBody] User input)
        {
            string guid = Database.CreateGUID();

            using IDbConnection cn = database.GetCn();
            cn.QueryAsync($"insert into {tableName} (id, name, phone_number) values ('{guid}', '{input.name}', '{input.phoneNumber}');");

            return new Dictionary<string, string> { { "userGuid", guid } };

        }
*/
        [HttpDelete(Name = "DeleteUser")]
        public void Delete([FromQuery] string id)
        {
/*            using IDbConnection cn = database.GetCn();
            cn.QueryAsync($"delete from {tableName} where id='{id}';");
*/        }
    }
}
