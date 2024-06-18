
using DataTypes;

namespace Backend
{
    public static class DependencyHandler
    {
        public static Pesanan PullDependency(this Pesanan pesanan, Database db)
        {
            pesanan.Produk = db.produk.FirstOrDefault(i => i.Id == pesanan.IdProduk);
            pesanan.Pembeli = db.pembeli.FirstOrDefault(i => i.Id == pesanan.IdPembeli);
            pesanan.Penjual = db.penjual.FirstOrDefault(i => i.Id == pesanan.IdPenjual);
            return pesanan;
        }
    }
}