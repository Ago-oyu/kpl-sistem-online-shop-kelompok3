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
        Config config = Config.GetConfig();
        public DbSet<Produk> produk { get; set; }
        public DbSet<Penjual> penjual { get; set; }
        public DbSet<Pembeli> pembeli { get; set; }
        public DbSet<Keranjang> keranjang { get; set; }
        public DbSet<Pesanan> pesanan { get; set; }

        public Database()
        {
            // TODO: ganti jadi definisi table sendiri (foreign key, etc)
            try
            {
                RelationalDatabaseCreator databaseCreator = 
                    (RelationalDatabaseCreator) Database.GetService<IDatabaseCreator>();
                databaseCreator.CreateTables();

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

                produk.Add(prd);

                prd = new()
                {
                    Nama="pulpen",
                    Harga=20000,
                    IDPenjual="tes",
                    Deskripsi="alat tulis",
                    Stok=5
                };

                produk.Add(prd);

                prd = new()
                {
                    Nama="penggaris",
                    Harga=50000,
                    IDPenjual="tes",
                    Deskripsi="alat tulis",
                    Stok=10
                };

                produk.Add(prd);

                prd = new()
                {
                    Nama="kursi",
                    Harga=100000,
                    IDPenjual="tes",
                    Deskripsi="alat tulis",
                    Stok=100
                };

                produk.Add(prd);

                SaveChanges();

            } catch (Exception)
            {
                // table sudah dibuat
            }
            
        }
        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={config.dataSource}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<User>()
            //     .HasOne(e => e.productId)
            //     .WithOne()
            //     .HasForeignKey<Product>(e => e.id);
        }
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