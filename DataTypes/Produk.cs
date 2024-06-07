

using System.Text.Json;

namespace DataTypes
{
    public class Produk : Syncronizeable<Produk>
    {
        public string Nama {get; set;}

        public Produk()
        {

        }

        public static async Task<List<Produk>> GetPage()
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

                    return JsonSerializer.Deserialize<List<Produk>>(responseBody);
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
}