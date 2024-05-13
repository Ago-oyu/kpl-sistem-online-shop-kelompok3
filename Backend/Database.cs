using System.Data;
using System.Data.SQLite;
using Dapper;

namespace Backend
{
    public class Database
    {
        string dataSource;
        Config config = Config.GetConfig();
        public Database(string? dataSource=null)
        {
            // load dari config jika dataSource tidak di input
            if (dataSource is null)
            {
                dataSource = config.dataSource;
            }

            // nama file database
            this.dataSource = dataSource;

            // inisialisasi table
            InitDatabase();
        }
        void InitDatabase()
        {
            var createTable = @"
            CREATE TABLE IF NOT EXISTS product (
                id VARCHAR(50) PRIMARY KEY,
                name VARCHAR(100),
                stock INTEGER
                );

            CREATE TABLE IF NOT EXISTS user (
                id VARCHAR(50) PRIMARY KEY,
                name VARCHAR(100),
                phone_number VARCHAR(100)
                );";

            using var cn = GetCn();
            cn.Query(createTable);
        }
        public IDbConnection GetCn()
        {
            return new SQLiteConnection($"Data Source={dataSource}");
        }
        public static string CreateGUID()
        {
            string guid = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            return guid.Substring(0, guid.Length-2);
        }
    }
}
