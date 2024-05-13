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
        private DaftarProduk<Penjual> ProdukList { get; set; }
        public enum Status { New, Bronze, Silver, Gold, Diamond}
        public int[] BatasPoin = { 0, 5, 50, 100, 250 };
        private int poin;
        private Status StatusToko { get; set; }

        public Penjual(string Nama, string Email, string Password, String NamaToko) : base(Nama, Email, Password)
        {
            this.NamaToko = NamaToko;
            ProdukList = new DaftarProduk<Penjual>();
            StatusToko = Enum.Parse(typeof(Status), 0);
        }

        public void UpdateStatusToko()
        {
            for (int i = 0; i < BatasPoin.Length; i++)
            {
                if (poin >= BatasPoin[i])
                {
                    continue;
                } else
                {
                    StatusToko = (Status)BatasPoin[i];
                }
            }
        }

        

        //public void AddProduk(Produk produk)
        //{
        //    ProdukList.Add(produk);
        //}

        //public void RemoveProduk(String produkId)
        //{
        //    for (int i = 0; i < ProdukList.Count; i++)
        //    {
        //        if (ProdukList[i].GetId().Equals(produkId))
        //        {
        //            ProdukList.RemoveAt(i);
        //            return;
        //        }
        //    }
        //}
    }
}
