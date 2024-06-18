

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

        public string NamaProduk {  get; set; }
        public string NamaPenjual {  get; set; }
        public string NamaPembeli {  get; set; }

        public int JumlahPesanan { get; set; }
        public int TotalHarga { get; set; }

        public Pesanan(string Id=null) : base(Id)
        {

        }
    }
}