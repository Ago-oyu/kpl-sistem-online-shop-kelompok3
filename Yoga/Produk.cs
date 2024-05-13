using UtilityLibrary;
namespace Yoga
{
    public class Produk
    {

        private static int productCount = 0;
        private string Id, nama;

        public Produk(string nama, string kategori )
        {
            this.Id = Toko.GenId(kategori, ++productCount);
            this.nama = nama;
        }

        public string GetNama()
        {
            return nama;
        }

        public string GetId()
        {
            return Id;
        }
    }
}