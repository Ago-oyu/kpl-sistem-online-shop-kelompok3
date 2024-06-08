using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Pembeli(string Email, string Password) : User<Pembeli>(Email, Password)
    {
        public string Alamat {get; set;}
        public string Keranjang {get; set;}
        public List<string> ListPesanan {get; set;}
    }
}
