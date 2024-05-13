using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoga
{
    public class Penjual : User
    {
        public String NamaToko {  get; set; }
        private List<Produk> ProdukList { get; set; 

        public Penjual(string Nama, string Email, string Password, String NamaToko) : base(Nama, Email, Password)
        {
            this.NamaToko = NamaToko;
            ProdukList = new List<Produk>();
        }

        public void AddProduk(Produk produk)
        {
            ProdukList.Add(produk);
        }

        public void RemoveProduk(String produkId)
        {
            for (int i = 0; i < ProdukList.Count; i++)
            {
                if (ProdukList[i].GetId().Equals(produkId))
                {
                    ProdukList.RemoveAt(i);
                    return;
                }
            }
        }


    }
}
