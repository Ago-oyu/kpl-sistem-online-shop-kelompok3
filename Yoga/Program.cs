// See https://aka.ms/new-console-template for more information
using UtilityLibrary;
using Yoga;


// Menunjukan library
Console.WriteLine("GenId():");

Produk produk1 = new Produk("Colokan", "elektronik");
Produk produk2 = new Produk("Charger", "elektronik");
Produk produk3 = new Produk("Palu", "alat");

Console.WriteLine(produk1.GetId());
Console.WriteLine(produk2.GetId());
Console.WriteLine(produk3.GetId());

Console.WriteLine("\nGetKategori():");
Penjual penjual1 = new Penjual("Yazov", "Yazov.Taboritsky@gmail.com", "password", "");
penjual1.AddProduk(produk3);
penjual1.AddProduk(produk1);
penjual1.AddProduk(produk2);


Console.WriteLine("Alat:");
foreach (Produk produk in penjual1.GetProdukList())
{
    if (Toko.GetKategori(produk.GetId()) == "alat")
    {
        Console.WriteLine(produk.GetNama());
    }
}

Console.WriteLine("\nElektronik");
foreach (Produk produk in penjual1.GetProdukList())
{
    if (Toko.GetKategori(produk.GetId()) == "elektronik")
    {
        Console.WriteLine(produk.GetNama());
    }
}

