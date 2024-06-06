﻿using System;
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
        
        public List<Produk> GetProdukList()
        {
            return Produk.GetList(ProdukList).Result;
        }
    }
}
