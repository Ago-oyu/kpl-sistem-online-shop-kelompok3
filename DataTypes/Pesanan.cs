

using System.Text.Json;

namespace DataTypes
{
    public enum StatusPesanan {packing, perjalanan, sampai}
    public class Pesanan : Syncronizeable<Produk>
    {
        public StatusPesanan Status {get; set;}
        public Produk Produk {get; set;}
        public Penjual Penjual {get; set;}
        public Pembeli Pembeli {get; set;}

        public Pesanan()
        {

        }
    }
}