

using System.ComponentModel.DataAnnotations.Schema;
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
        [JsonIgnore]
        public Produk Produk {get; set;}
        public string PenjualID {get; set;}
        [NotMapped]
        [JsonIgnore]
        public Penjual Penjual {get; set;}
        public string PembeliID {get; set;}
        [NotMapped]
        [JsonIgnore]
        public Pembeli Pembeli {get; set;}
        
        public int stok { get; set; }
        public int totalHarga { get; set; }


        public Pesanan(string Id=null) : base(Id)
        {

        }
    }
}