using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Backend
{
    public class Config
    {
        public string dataSource = "./database.db";
        public string host = "localhost";
        public string port = "5058";
        
        public static T GetConfig<T>(string path = "./backend_config.json") where T : new()
        {
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true,
            };
            
            if (!File.Exists(path))
            {
                T config = new();
                File.WriteAllText(path, JsonSerializer.Serialize(config, options));
                return config;
            }
            
            string jsText = File.ReadAllText(path);
            try
            {
                return JsonSerializer.Deserialize<T>(jsText, options);
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid config", ex);
            }
        }
    }
}
