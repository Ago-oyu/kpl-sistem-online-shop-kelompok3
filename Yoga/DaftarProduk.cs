using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoga
{
     class DaftarProduk<T> : List<Produk>
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
            if (tipe is Penjual)
            {
                Produk Terlaris = this[0];
                for (int i = 0; i < this.Count; i++)
                {
                    if (this[i].GetTerjual() > Terlaris.GetTerjual())
                    {
                        Terlaris = this[i];
                    }
                }
                return Terlaris;
            } else
            {
                Console.WriteLine("Method GetTerlaris hanya untuk penjual");
                return null;
            }
        }

        public int GetTotalPenjualan()
        {
            int totalPenjualan = 0;
            for (int i = 0;i < this.Count;i++)
            {
                totalPenjualan += this[i].GetTerjual();
            }
            return totalPenjualan;
        }
    }
}
