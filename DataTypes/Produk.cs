

using System.Text.Json;

namespace DataTypes
{
    public class Produk : Syncronizeable<Produk>
    {
        public enum Sorting { none, random, diskon, harga }
        public enum SortDir { asc, desc }
        public string Nama {get; set;}
        public int Harga { get; set; }
        public string TokoPenjual { get; set; }
        public string NamaPenjual { get; set; }
        public string Deskripsi { get; set; }
        public int Stok { get; set; }

        public Produk(string Id=null) : base(Id)
        {

        }

        /// <summary>
        /// return hasil query table produk, kalau page < 1 return semua item di table produk
        /// </summary>
        /// <param name="page">page berapa, kalau kurang dari 0 return semua item di table produk</param>
        /// <param name="itemPerPage">item per page berapa kalau parameter page lebih dari 0</param>
        /// <param name="sort">sorting apa</param>
        /// <param name="dir">sorting direction nya apa</param>
        /// <returns></returns>
        public static async Task<List<Produk>> GetPage(int page=-1, int itemPerPage=20, Sorting sort=Sorting.none, SortDir dir=SortDir.asc)
        {
            using var client = new HttpClient();

            string requestUrl = baseUrl + $"/api/getProductPage?page={page}&batch={itemPerPage}&sort={sort}&dir={dir}";
            
            // try
            // {
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
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine($"An error occurred: {ex.Message}");
            // }
            return null;
        }
    }
}