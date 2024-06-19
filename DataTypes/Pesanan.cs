

using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataTypes
{
    public enum StatusPesanan {packing, perjalanan, sampai}
    public class Pesanan: Syncronizeable<Pesanan>
    {
        public StatusPesanan Status {get; set;}

        public string ProdukID {get; set;}
        [NotMapped]
        public Produk Produk {get; set;}
        public string PenjualID {get; set;}
        [NotMapped]
        public Penjual Penjual {get; set;}
        public string PembeliID {get; set;}
        [NotMapped]
        public Pembeli Pembeli {get; set;}
        
        public int stok { get; set; }
        public int totalHarga { get; set; }
        public string status { get; set; }

        public Pesanan(string Id=null) : base(Id)
        {

        }
        public async static Task<List<Pesanan>> GetListPesanan()
        {
            using var client = new HttpClient();

            string requestUrl = baseUrl + endpoint + "/many";
            
            // try
            // {
                HttpResponseMessage response = await client.GetAsync(requestUrl);

                // Check if the request was successful (status code 200)
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    return JsonSerializer.Deserialize<List<Pesanan>>(responseBody);
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