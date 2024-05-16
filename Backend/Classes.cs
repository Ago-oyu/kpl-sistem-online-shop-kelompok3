using System.CodeDom;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json;
using Mapster;

namespace Backend
{
    public class Product : Syncronizeable<Product>
    {
        // [Key]
        // public string id { get; set; }
        public string name { get; set; }
        public int stock { get; set; }

        public static async Task<List<Product>> GetPage()
        {
            using var client = new HttpClient();

            string requestUrl = baseUrl + "/api/getProductPage";

            try
            {
                HttpResponseMessage response = await client.GetAsync(requestUrl);

                // Check if the request was successful (status code 200)
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    return JsonSerializer.Deserialize<List<Product>>(responseBody);
                }
                else
                {
                    Console.WriteLine($"Failed to call the API. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return null;
        }
    }
    public class User : Syncronizeable<User>
    {
        // [Key]
        // public string? id { get; set; }
        public string name { get; set; }
        public Int64 phoneNumber { get; set; }
        public List<string> products { get; set; }

    }
    public class Syncronizeable<T> where T : class
    {
        [Key]
        public string id { get; set; }
        public static string baseUrl;
        public static string endpoint;
        public async Task Pull()
        {
            
            var serverObj = await Get(id);
            if (serverObj is not null)
                serverObj.Adapt(this as T);
            else
                Console.WriteLine("objek tidak ada di server");
        }
        public async Task<string> Push()
        {
            using var client = new HttpClient();

            string requestUrl = baseUrl + endpoint;

            var content = new StringContent(Serialize(), Encoding.UTF8, "application/json");
            
            try
            {
                HttpResponseMessage response = await client.PostAsync(requestUrl, content);

                string responseBody = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {

                    return responseBody;
                }
                else
                {
                    return $"Failed to call the API. Status code: {response.StatusCode} {responseBody}";
                }
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }
        public static async Task<T> Get(string id)
        {
            using var client = new HttpClient();

            string requestUrl = baseUrl + endpoint + "/" + id;

            try
            {
                HttpResponseMessage response = await client.GetAsync(requestUrl);

                // Check if the request was successful (status code 200)
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    return JsonSerializer.Deserialize<T>(responseBody);
                }
                else
                {
                    Console.WriteLine($"Failed to call the API. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return default;
        }
        
        public virtual void ForeignKeyCheck(Database db)
        {
            
        }
        public string Serialize()
        {
            return JsonSerializer.Serialize(this as T);
        }
    
    }
}
