using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Keranjang : Syncronizeable<Keranjang>
    {
        public List<string> listBelanja;
        public List<Produk> GetListBelanja()
        {
            return Produk.GetList(listBelanja).Result;
        }
    }
}
