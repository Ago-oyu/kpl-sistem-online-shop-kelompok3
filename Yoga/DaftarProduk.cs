using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoga
{
     public class DaftarProduk<T> : List<Produk>
    {
        T tipe;
        public void RemoveProduk(String ProdukId)
        {
            if (ProdukId == null)
            {
                Console.WriteLine("Id Produk Tidak Valid");
            }
            else
            {
                for (int i = 0; i < this.Count; i++)
                {
                    if (this[i].GetId().Equals(ProdukId))
                    {
                        this.RemoveAt(i);
                        return;
                    }
                }
            }
        }
        public Produk GetTerlaris()
        {
            Produk Terlaris = this[0];
            try
            {
                if (tipe is Penjual)
                {
                    for (int i = 0; i < this.Count; i++)
                    {
                        if (this[i].GetJmlPenjualan() > Terlaris.GetJmlPenjualan())
                        {
                            Terlaris = this[i];
                        }
                    }
                }
                return Terlaris;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Method GetTerlaris hanya untuk penjual");
                return Terlaris;
            }
        }

        public int GetTotalPenjualan()
        {
            int totalPenjualan = 0;
            for (int i = 0;i < this.Count;i++)
            {
                totalPenjualan += this[i].GetJmlPenjualan();
            }
            return totalPenjualan;
        }
    }
}
