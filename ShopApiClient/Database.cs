using DataTypes;
using System.Runtime.InteropServices;

namespace ShopApiClient
{
    public class Database
    {
        private static List<Produk> listProduk;
        private static List<Pesanan> listPesanan;

        public static async Task<List<Produk>> GetProdukList()
        {
            if (listProduk == null)
            {
                listProduk = await Produk.GetPage();
            }
            
            return listProduk;
        }

        public static async Task<List<Produk>> GetProdukList(Penjual penj)
        {
            if (listProduk == null)
            {
                listProduk = await Produk.GetPage();
            }

            List<Produk> TempList = new();
            foreach (Produk produk in await Produk.GetPage())
            {
                if (produk.IDPenjual == penj.Id)
                {
                    TempList.Add(produk);
                }
            }
            return TempList;
        }

        public static void AddProduk(Produk produk)
        {
            listProduk.Add(produk);
        }

        public static async Task Refresh()
        {
            Reset();
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
