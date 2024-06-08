using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Keranjang : Syncronizeable<Keranjang>
    {
        public List<string> ListBelanja {get; set;}
        public async Task<List<Produk>> GetListBelanja()
        {
            return await Produk.GetList(ListBelanja);
        }
    }
}
