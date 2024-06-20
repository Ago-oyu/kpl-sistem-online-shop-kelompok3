using DataTypes;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace ShopManagementLib
{
    public class ShopRepository
    {
        private static List<Produk> listProduk;
        private static List<Pesanan> listPesanan;

        private enum FilterJumlah
        {
            Sedikit,
            Sedang,
            Banyak
        }

        private static readonly int[] BatasJumlahPesanan = { 0, 10, 25, int.MaxValue };

        public static async Task<List<Produk>> GetProdukList()
        {
            if (listProduk == null)
            {
                listProduk = await Produk.GetPage();
            }
            return listProduk;
        }

        public static async Task<Produk> GetProduk(string id)
        {
            if (listProduk == null)
            {
                listProduk = await Produk.GetPage();
            }

            return listProduk.FirstOrDefault(produk => produk.Id == id);
        }

        public static async Task<List<Produk>> GetProdukList(Penjual penjual)
        {
            if (listProduk == null)
            {
                listProduk = await Produk.GetPage();
            }

            return listProduk.Where(produk => produk.IDPenjual == penjual.Id).ToList();
        }

        public static async Task<List<Pesanan>> GetPesananList(Pembeli pembeli)
        {
            if (listPesanan == null)
            {
                listPesanan = await Pesanan.GetListPesanan();
            }

            return listPesanan.Where(pesanan => pesanan.PembeliID == pembeli.Id).ToList();
        }

        public static async Task<List<Pesanan>> GetPesananList(Penjual penjual, string filterJumlah = null)
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

        public static void AddProduk(Produk produk)
        {
            listProduk.Add(produk);
            produk.Push();
        }

        public static async Task DeleteProduk(string id)
        {
            Produk deletedProduk = await GetProduk(id);
            if (deletedProduk != null)
            {
                listProduk.Remove(deletedProduk);
                deletedProduk.Delete();
            }
        }

        public static async Task Refresh()
        {
            await Reset();
            listProduk = await Produk.GetPage();
            listPesanan = await Pesanan.GetListPesanan();
        }

        public static async Task Reset()
        {
            listProduk = null;
            listPesanan = null;
        }
    }
}