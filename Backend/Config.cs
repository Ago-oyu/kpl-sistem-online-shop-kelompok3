using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;

namespace Backend
{
    public class Config
    {
        public string dataSource = "./database.db";
        public string host = "localhost";
        public string port = "5058";
        public static Config GetConfig (string path="./backend_config.json")
        {
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true,
            };
            if (!File.Exists(path))
            {
                Config config = new();
                File.WriteAllText(path, JsonSerializer.Serialize(config, options));

                return config;
            }
            string jsText = File.ReadAllText(path);
            try {
                return JsonSerializer.Deserialize<Config>(jsText, options);
            } catch (Exception ex) {
                throw new Exception("Invalid config");
            }
        }
    }
}