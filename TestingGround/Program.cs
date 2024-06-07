using System.Data.Common;
using System.Text.Json;
using Backend;
using DataTypes;

Produk.baseUrl = "https://localhost:5058/swagger";
Produk.endpoint = "/api/produk";

Pembeli.baseUrl = "https://localhost:5058/swagger";
Pembeli.endpoint = "/api/user";

Produk prd = new();
prd.Id = Database.CreateGUID();

Console.WriteLine(prd.Id);

prd.Nama = "pensil";
string res = await prd.Push();

Console.WriteLine($"{prd.Id}: {res}");