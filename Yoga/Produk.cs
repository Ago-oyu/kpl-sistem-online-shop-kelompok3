using UtilityLibrary;
namespace Yoga
{
    public class Produk
    {
        private String Description;
        private int JmlPenjualan;

        private static int productCount = 0;
        private string Id, Nama;

        public Produk(string nama, string kategori )
        {
            this.Id = Toko.GenId(kategori, ++productCount);
            this.Nama = nama;
        }

        public string GetNama()
        {
            return Nama;
        }

        public string GetId()
        {
            return Id;
        }

        public int GetJmlPenjualan()
        {
            return JmlPenjualan;
        }

        public void AddPenjualan(int Terjual)
        {
            JmlPenjualan += Terjual;
        }
    }
}