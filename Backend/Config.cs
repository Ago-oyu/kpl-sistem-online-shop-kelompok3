using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;

namespace Backend
{
    public class Config
    {
        public string dataSource;
        public string host;
        public string port;
        public static Config GetConfig (string path="./backend_config.json")
        {
            var options = new JsonSerializerOptions
            {
                IncludeFields = true
            };

            if (!File.Exists(path))
            {
                Config config = new();
                config.SetDefault();
                File.WriteAllText(path, JsonSerializer.Serialize(config, options));
                
                return config;
            }
            string jsText = File.ReadAllText(path);

            
            return JsonSerializer.Deserialize<Config>(jsText, options);
        }
        public void SetDefault()
        {
            dataSource = "./database.db";
            host = "localhost";
            port = "5058";
        }
    }
}