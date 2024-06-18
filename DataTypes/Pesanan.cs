

using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace DataTypes
{
    public enum StatusPesanan {packing, perjalanan, sampai}
    public class Pesanan: Syncronizeable<Pesanan>
    {
        public StatusPesanan Status {get; set;}
        public string IdProduk {get; set;}
        [NotMapped]
        public Produk Produk {get; set;}
        public string IdPenjual {get; set;}
        [NotMapped]
        public Penjual Penjual {get; set;}
        public string IdPembeli {get; set;}
        [NotMapped]
        public Pembeli Pembeli {get; set;}

        public Pesanan(string Id=null) : base(Id)
        {

        }
    }
}