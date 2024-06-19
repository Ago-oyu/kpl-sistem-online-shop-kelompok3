using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Penjual : User<Penjual>, IHashable
    {
        public string NamaToko {  get; set; }
        private List<string> ProdukList { get; set; } 
        public Penjual(string Email, string Password) : base(Email, Password) { }
        public Penjual() : base(null, null) { }

        public async Task<List<Produk>> GetProdukList()
        {
            return await Produk.GetList(ProdukList);
        }
    }
}
