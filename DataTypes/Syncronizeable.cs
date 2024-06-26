using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;
using Mapster;

namespace DataTypes
{
    public class Syncronizeable<T> where T : class
    {
        [Key]
        public string Id { get; set; }
        public static string baseUrl= null;
        public static string endpoint = null;
        public static void Setup(string baseUrlIn, string endpointIn)
        {
            baseUrl = baseUrlIn;
            endpoint = endpointIn;

        }
        
        public Syncronizeable(string Id=null)
        {
            this.Id = Id;
            if (Id == null)
                this.Id = CreateGUID();
        }

        /// <summary>
        /// update objek caller dengan data terbaru dari database
        /// untuk Child Class User Email dan Password harus ter set dengan tepat agar bisa pull (class lain cukup Id)
        /// </summary>
        public async Task Pull()
        {
            var serverObj = await Get(Id);
            if (serverObj is not null)
                serverObj.Adapt(this as T);
            else
                Console.WriteLine("objek tidak ada di server");
        }

        /// <summary>
        /// update row di database untuk objek caller berdasarkan field Id
        /// untuk Child Class User Password harus ter set dengan tepat agar bisa push
        /// </summary>
        public async Task<string> Push()
        {
            using var client = new HttpClient();

            string requestUrl = baseUrl + endpoint;

            // Console.WriteLine(requestUrl);

            var content = new StringContent(Serialize(), Encoding.UTF8, "application/json");
            
            // try
            // {
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
            // }
            // catch (Exception ex)
            // {
            //     return $"An error occurred: {ex.Message}";
            // }
        }

        /// <summary>
        /// ambil objek dari database berdasarkan Id
        /// untuk child class user gunakan method Login untuk mengambil data
        /// </summary>
        /// <returns>instance objek dari database dengan id sesuai parameter</returns>
        public static async Task<T> Get(string id)
        {
            using var client = new HttpClient();

            string requestUrl = baseUrl + endpoint + "/" + id;

            // try
            // {
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
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine($"An error occurred: {ex.Message}");
            // }
            return default;
        }
        public static async Task<List<T>> GetList(IEnumerable<string> ids)
        {
            // agar bise request secara parallel
            var tasks = ids.Select(Get).ToList();
            var results = await Task.WhenAll(tasks);
            return results.ToList();
        }

        /// <summary>
        /// hapus objek ini dari database berdasarkan Id
        /// </summary>
        public async Task Delete()
        {
           await Delete(Id);
        }
        public static async Task Delete(string id)
        {
            using var client = new HttpClient();

            string requestUrl = baseUrl + endpoint + "/" + id;

            // try
            // {
                HttpResponseMessage response = await client.DeleteAsync(requestUrl);

                // Check if the request was successful (status code 200)
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    Console.WriteLine($"Failed to call the API. Status code: {response.StatusCode}");
                }
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine($"An error occurred: {ex.Message}");
            // }
        }
        public string Serialize()
        {
            return JsonSerializer.Serialize(this as T);
        }

        public static string CreateGUID()
        {
            // string guid = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            // return guid.Substring(0, guid.Length-2);

            return Guid.NewGuid().ToString();
        }
    }
}