using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Pembeli : User<Pembeli>
    {
        public string alamat;
        public string keranjang;

        public Pembeli(string Nama, string Email, string Password) : base(Nama, Email, Password)
        {

        }
    }
}
