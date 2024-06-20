using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Pembeli: User<Pembeli>, IHashable
    {
        public string Alamat {get; set;}
        public string Keranjang {get; set;}
        public List<string> ListPesanan {get; set;}
        public Pembeli(string Email, string Password) : base(Email, Password) { }
        public Pembeli() : base(null, null) { }
    }
}
