using System;
using System.Collections.Generic;

public class Product<T>
{
    public T ID { get; set; }
    public string Nama { get; set; }
    public double Harga { get; set; }
    public int Stok { get; set; }

    public Product(T id, string nama, double harga, int stok)
    {
        ID = id;
        Nama = nama;
        Harga = harga;
        Stok = stok;
    }
}
