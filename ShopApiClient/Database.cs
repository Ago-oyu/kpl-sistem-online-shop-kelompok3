using DataTypes;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace ShopApiClient
{
    public class Database
    {
        private static List<Produk> listProduk;
        private static List<Pesanan> listPesanan;

        private enum FilterJumlah
        {
            sedikit,
            sedang,
            banyak
        }
        private static int[] BatasJumlahPesanan = new int[4] {0, 10, 25, int.MaxValue };

        public static async Task<List<Produk>> GetProdukList()
        {
            if (listProduk == null)
            {
                listProduk = await Produk.GetPage();
            }

            //List<Produk> TempList = new();
            //foreach (Produk produk in listProduk)
            //{
            //    if (produk.Stok > 0)
            //    {
            //        TempList.Add(produk);
            //    }
            //}
            //return TempList;
            return listProduk;
        }



        public static async Task<Produk> GetProduk(string ID)
        {
            if (listProduk == null)
            {
                listProduk = await Produk.GetPage();
            }

            foreach (Produk produk in listProduk)
            {
                if (produk.Id == ID)
                {
                    return produk;
                }
            }
            return null;
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

        public static async Task<List<Pesanan>> GetPesananList(Penjual penj, string filterJumlah=null)
        {
            FilterJumlah filterJumlah1;

            if (listPesanan == null)
            {
                listPesanan = await Pesanan.GetListPesanan();
                listPesanan = listPesanan.Where(pesanan => pesanan.PenjualID == penj.Id).ToList();
            }

            if (filterJumlah != "semua") {
                Enum.TryParse(filterJumlah, out filterJumlah1);

                listPesanan = listPesanan.Where(pesanan => pesanan.stok > BatasJumlahPesanan[(int)filterJumlah1] && pesanan.stok <= BatasJumlahPesanan[(int)filterJumlah1 + 1]).ToList();
            }

            return listPesanan;
        }

        public static void AddProduk(Produk produk)
        {
            listProduk.Add(produk);
            produk.Push();
        }

        public static async Task DeleteProduk(string ID)
        {
            Produk deletedProduk = await GetProduk(ID);
            if (deletedProduk != null)
            {
                listProduk.Remove(deletedProduk);
                deletedProduk.Delete();
            }
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
