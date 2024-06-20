using DataTypes;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace ShopManagementLib
{
    public class ShopRepository
    {
        private static ShopRepository Ins = null;
        private List<Produk> listProduk;
        private List<Pesanan> listPesanan;

        private enum FilterJumlah
        {
            Sedikit,
            Sedang,
            Banyak
        }

        private ShopRepository()
        {
            listProduk = new();
            listPesanan = new();
        }

        public static ShopRepository GetShopRepository()
        {
            if (Ins == null)
                Ins = new();
                
            return Ins;
        }

        private readonly int[] BatasJumlahPesanan = { 0, 10, 25, int.MaxValue };

        public async Task<List<Produk>> GetProdukList()
        {
            if (listProduk == null)
            {
                listProduk = await Produk.GetPage();
            }
            return listProduk;
        }

        public async Task<Produk> GetProduk(string id)
        {
            if (listProduk == null)
            {
                listProduk = await Produk.GetPage();
            }

            return listProduk.FirstOrDefault(produk => produk.Id == id);
        }

        public async Task<List<Produk>> GetProdukList(Penjual penjual)
        {
            if (listProduk == null)
            {
                listProduk = await Produk.GetPage();
            }

            return listProduk.Where(produk => produk.IDPenjual == penjual.Id).ToList();
        }

        public async Task<List<Pesanan>> GetPesananList(Pembeli pembeli)
        {
            if (listPesanan == null)
            {
                listPesanan = await Pesanan.GetListPesanan();
            }

            return listPesanan.Where(pesanan => pesanan.PembeliID == pembeli.Id).ToList();
        }

        public async Task<List<Pesanan>> GetPesananList(Penjual penjual, string filterJumlah = null)
        {
            if (listPesanan == null)
            {
                listPesanan = await Pesanan.GetListPesanan();
            }

            listPesanan = listPesanan.Where(pesanan => pesanan.PenjualID == penjual.Id).ToList();

            if (filterJumlah != null && filterJumlah != "semua")
            {
                if (Enum.TryParse(filterJumlah, true, out FilterJumlah filterJumlahEnum))
                {
                    int lowerBound = BatasJumlahPesanan[(int)filterJumlahEnum];
                    int upperBound = BatasJumlahPesanan[(int)filterJumlahEnum + 1];

                    listPesanan = listPesanan
                        .Where(pesanan => pesanan.stok > lowerBound && pesanan.stok <= upperBound)
                        .ToList();
                }
            }

            return listPesanan;
        }

        public void AddProduk(Produk produk)
        {
            listProduk.Add(produk);
            produk.Push();
        }

        public async Task DeleteProduk(string id)
        {
            Produk deletedProduk = await GetProduk(id);
            if (deletedProduk != null)
            {
                listProduk.Remove(deletedProduk);
                deletedProduk.Delete();
            }
        }

        public async Task Refresh()
        {
            await Reset();
            listProduk = await Produk.GetPage();
            listPesanan = await Pesanan.GetListPesanan();
        }

        public async Task Reset()
        {
            listProduk = null;
            listPesanan = null;
        }
    }
}