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

            List<Produk> TempList = new();
            foreach (Produk produk in listProduk)
            {
                if (produk.Stok > 0)
                {
                    TempList.Add(produk);
                }
            }
            return TempList;
        }

        public static async Task<List<Produk>> GetProdukList(Penjual penj)
        {
            if (listProduk == null)
            {
                listProduk = await Produk.GetPage();
            }

            List<Produk> TempList = new();
            foreach (Produk produk in listProduk)
            {
                if (produk.IDPenjual == penj.Id)
                {
                    TempList.Add(produk);
                }
            }
            return TempList;
        }

        public static async Task<List<Pesanan>> GetPesananList(Pembeli pem)
        {
            if (listPesanan == null)
            {
                listPesanan = await Pesanan.GetListPesanan();
            }

            List<Pesanan> TempList = new();
            foreach (Pesanan pesanan in listPesanan)
            {
                if (pesanan.PembeliID == pem.Id)
                {
                    TempList.Add(pesanan);
                }
            }
            return TempList;
        }

        public static async Task<List<Pesanan>> GetPesananList(Penjual penj)
        {
            if (listPesanan == null)
            {
                listPesanan = await Pesanan.GetListPesanan();
            }

            List<Pesanan> TempList = new();
            foreach (Pesanan pesanan in listPesanan)
            {
                if (pesanan.PenjualID == penj.Id)
                {
                    TempList.Add(pesanan);
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
