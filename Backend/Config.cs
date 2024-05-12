using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;

namespace Backend
{
    public class Config
    {
        public string dataSource;
        public static Config GetConfig (string path="./backend_config.json")
        {
            if (!File.Exists(path))
            {
                Config config = new();
                config.SetDefault();
                File.WriteAllText(path, JsonSerializer.Serialize(config));

                return config;
            }
            string jsText = File.ReadAllText(path);

            var options = new JsonSerializerOptions
            {
                IncludeFields = true
            };
            return JsonSerializer.Deserialize<Config>(jsText, options);
        }
        public void SetDefault()
        {
            dataSource = "./database.db";
        }
    }
}