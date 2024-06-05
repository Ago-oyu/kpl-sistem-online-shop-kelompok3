

namespace DataTypes
{
    public class Produk : Syncronizeable<Produk>
    {
        public string nama;

        public Produk()
        {

        }

        public Produk(string nama)
        {
            this.nama = nama;
        }
    }
}