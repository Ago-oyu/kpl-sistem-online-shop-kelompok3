
using DataTypes;

namespace Backend
{
    public static class DependencyHandler
    {
        public static Pesanan PullDependency(this Pesanan pesanan, Database db)
        {
            pesanan.Produk = db.Produk.FirstOrDefault(i => i.Id == pesanan.ProdukID);
            pesanan.Pembeli = db.Pembeli.FirstOrDefault(i => i.Id == pesanan.PembeliID);
            pesanan.Penjual = db.Penjual.FirstOrDefault(i => i.Id == pesanan.PenjualID);
            return pesanan;
        }

        public static Produk PullDependency(this Produk produk, Database db)
        {
            return produk;
        }
    }
}