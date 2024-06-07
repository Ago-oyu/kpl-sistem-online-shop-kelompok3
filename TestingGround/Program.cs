using System.Data.Common;
using System.Text.Json;
using Backend;
using DataTypes;

string baseUrl = "http://localhost:5058";

Produk.baseUrl = baseUrl;
Produk.endpoint = "/api/produk";

Pembeli.baseUrl = baseUrl;
Pembeli.endpoint = "/api/pembeli";

string email = "testing@mail.com";
string pass = "jola";

Pembeli newUser = new()
{
    Nama = "test",
    Email = email,
    Password = pass,
    Id = Database.CreateGUID(),
    Alamat = "bumi"
};


Console.WriteLine(await newUser.Register());

LoginInfo info = new() { Email = email, Password = pass };

LoginOut<Pembeli> res = Pembeli.Login(info).Result;

// res.Status kalau login gagal info disini
// res.Info objek hasil login;

Console.WriteLine("# init");
Console.WriteLine(JsonSerializer.Serialize(res));

Pembeli user = res.Info;
user.Nama = "john";
await user.Push();

res = Pembeli.Login(info).Result;

Console.WriteLine("# update nama");
Console.WriteLine(JsonSerializer.Serialize(res));

Pembeli newUsr = new();
// newUsr.Id = user.Id;
newUsr.Email = user.Email;
newUsr.Password = user.Password;

Console.WriteLine("# pre update");
Console.WriteLine(JsonSerializer.Serialize(newUsr));

await newUsr.Pull();
Console.WriteLine("# post update");
Console.WriteLine(JsonSerializer.Serialize(newUsr));


// Console.WriteLine(await newUser.Register());

// info = new(){ Type = UserTypes.pembeli, Email=email, Password=pass };
// user = Pembeli.Login(info).Result;

// Console.WriteLine("# post register");
// Console.WriteLine(JsonSerializer.Serialize(user));