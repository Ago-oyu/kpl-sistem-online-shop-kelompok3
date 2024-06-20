using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.ComponentModel;
using DataTypes;
using System.Text.Json;

namespace Backend
{
    public class Database : DbContext
    {
        readonly Config _config = Config.GetConfig<Config>();
        public DbSet<Produk> Produk { get; set; }
        public DbSet<Penjual> Penjual { get; set; }
        public DbSet<Pembeli> Pembeli { get; set; }
        public DbSet<Keranjang> Keranjang { get; set; }
        public DbSet<Pesanan> Pesanan { get; set; }

        public Database()
        {
            try
            {
                RelationalDatabaseCreator databaseCreator = 
                    (RelationalDatabaseCreator) Database.GetService<IDatabaseCreator>();
                databaseCreator.CreateTables();

                // pertama kali setup table isi dengan beberapa data dummy
                DatabaseUpdater updater = new(this);

                Penjual pjl = new()
                {
                    Id="tes", // buat ini aja harusnya dibiaring kosong
                    NamaToko="tes",
                    Nama="tes",
                    Password="tes",
                    Email="tes"
                };
                updater.InsertUser<Penjual>(JsonSerializer.SerializeToElement(pjl));

                Pembeli pmb = new()
                {
                    Id="testes", // buat ini aja harusnya dibiaring kosong
                    Alamat="tes",
                    Nama="tes",
                    Password="tes",
                    Email="tes"
                };
                updater.InsertUser<Pembeli>(JsonSerializer.SerializeToElement(pmb));

                Produk prd = new()
                {
                    Nama="pensil",
                    Harga=10000,
                    IDPenjual="tes",
                    Deskripsi="alat tulis",
                    Stok=1
                };

                Produk.Add(prd);

                prd = new()
                {
                    Nama="pulpen",
                    Harga=20000,
                    IDPenjual="tes",
                    Deskripsi="alat tulis",
                    Stok=5
                };

                Produk.Add(prd);

                prd = new()
                {
                    Nama="penggaris",
                    Harga=50000,
                    IDPenjual="tes",
                    Deskripsi="alat tulis",
                    Stok=10
                };

                Produk.Add(prd);

                prd = new()
                {
                    Nama="kursi",
                    Harga=100000,
                    IDPenjual="tes",
                    Deskripsi="alat tulis",
                    Stok=100
                };

                Produk.Add(prd);

                SaveChanges();

            } catch (Exception)
            {
                // catch exception jika table sudah dibuat
            }
            
        }

        // konfigurasi efcore sqlite dan data source
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={_config.dataSource}");
    }
    public class DatabaseUpdater
    {
        public enum Result {updated, inserted}
        public Database db;
        public DatabaseUpdater(Database db)
        {   
            this.db = db;
        }
        public Result Execute<T>(JsonElement input) where T : class
        {
            var row = GetRow<T>(input);
            if (row is null)
            {
                Insert<T>(input);
                return Result.inserted;
            }
            Update(row, input);
            return Result.updated;
        }
        public T GetRow<T>(JsonElement input) where T : class
        {
            var row = db.Find<T>(input.GetProperty("Id").GetString());
            return row;
        }
        public void Insert<T>(JsonElement input) where T : class
        {
            T parsedInput = Parse<T>(input);
            db.Add(parsedInput);
            db.SaveChanges();
        }
        public void Update<T>(T row, JsonElement input) where T : class
        {
            T parsedInput = Parse<T>(input);
            db.Entry(row).CurrentValues.SetValues(parsedInput);
            db.SaveChanges();
        }
        public void Update<T>(JsonElement input) where T : class
        {
            var row = GetRow<T>(input);
            T parsedInput = Parse<T>(input);
            db.Entry(row).CurrentValues.SetValues(parsedInput);
            db.SaveChanges();
            
        }
        public void InsertUser<T>(JsonElement input) where T : class, IHashable
        {
            T parsedInput = Parse<T>(input);
            parsedInput.Salt = PasswordHandler.CreateSalt();
            parsedInput.Password = PasswordHandler.GenerateSHA512Hash(parsedInput.Password, parsedInput.Salt);

            Insert<T>(JsonSerializer.SerializeToElement(parsedInput));
        }
        public void UpdateUser<T>(JsonElement input) where T : class, IHashable
        {
            var row = GetRow<T>(input);
            var inputParsed = Parse<T>(input);

            // agar password hashed di db tidak update dengna password plain text dan salt tidak ter hapus
            // karena 2 elemen ini hanya ada di backend jadi dari input user gak ada
            inputParsed.Password = row.Password;
            inputParsed.Salt = row.Salt;

            Update(row, JsonSerializer.SerializeToElement(inputParsed));
        }
        public T Parse<T>(JsonElement input)
        {
            return JsonSerializer.Deserialize<T>(input);
        }
    }
}