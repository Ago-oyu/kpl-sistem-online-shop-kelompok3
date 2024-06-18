

using System.Text.Json;

namespace DataTypes
{
    public enum StatusPesanan {packing, perjalanan, sampai}
    public class Pesanan: Syncronizeable<Pesanan>
    {
        public StatusPesanan Status {get; set;}
        public string ProdukID { get; set; }
        public string PenjualID { get; set; }
        public string PembeliID { get; set; }

        public int stok { get; set; }
        public int totalHarga { get; set; }

        public Pesanan(string Id=null) : base(Id)
        {

        }
    }
}