using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Penjual : User<Penjual>
    {
        public string NamaToko {  get; set; }
        private List<string> ProdukList { get; set; } 

        public Penjual(string Nama, string Email, string Password, String NamaToko) : base(Nama, Email, Password)
        {
            this.NamaToko = NamaToko;
            ProdukList = new();
        }

        public List<Produk> GetProdukList()
        {
            return Produk.GetList(ProdukList).Result;
        }
    }
}
