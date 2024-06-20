
using DataTypes;

namespace Backend
{
    public static class DependencyHandler
    {
        public static Pesanan PullDependency(this Pesanan pesanan, Database db)
        {
            pesanan.Produk = db.produk.FirstOrDefault(i => i.Id == pesanan.ProdukID);
            pesanan.Pembeli = db.pembeli.FirstOrDefault(i => i.Id == pesanan.PembeliID);
            pesanan.Penjual = db.penjual.FirstOrDefault(i => i.Id == pesanan.PenjualID);
            return pesanan;
        }

        public static Produk PullDependency(this Produk produk, Database db)
        {
            produk.Status = produk.UpdateStatus(produk.Stok);
            return produk;
        }
    }
}