

using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataTypes
{
    public enum StatusPesanan {packing, perjalanan, sampai}
    public class Pesanan: Syncronizeable<Pesanan>
    {
        public StatusPesanan Status {get; set;}
        public string IdProduk {get; set;}
        [NotMapped]
        [JsonIgnore]
        public Produk Produk {get; set;}
        public string IdPenjual {get; set;}
        [NotMapped]
        [JsonIgnore]
        public Penjual Penjual {get; set;}
        public string IdPembeli {get; set;}
        [NotMapped]
        [JsonIgnore]
        public Pembeli Pembeli {get; set;}

        public Pesanan(string Id=null) : base(Id)
        {

        }
    }
}