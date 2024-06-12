

using System.Text.Json;

namespace DataTypes
{
    public enum StatusPesanan {packing, perjalanan, sampai}
    public class Pesanan: Syncronizeable<Pesanan>
    {
        public StatusPesanan Status {get; set;}
        public string IdProduk {get; set;}
        public string IdPenjual {get; set;}
        public string IdPembeli {get; set;}

        public Pesanan(string Id=null) : base(Id)
        {

        }
    }
}