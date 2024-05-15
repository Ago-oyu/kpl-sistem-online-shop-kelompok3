using Backend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.ComponentModel;


namespace Backend
{
    public class Database : DbContext
    {
        Config config = Config.GetConfig();
        public DbSet<Product> product { get; set; }
        public DbSet<User> user { get; set; }

        public Database()
        {
            // TODO: ganti jadi definisi table sendiri (foreign key, etc)
            try
            {
                RelationalDatabaseCreator databaseCreator = 
                    (RelationalDatabaseCreator) Database.GetService<IDatabaseCreator>();
                databaseCreator.CreateTables();
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

        public static string CreateGUID()
        {
            string guid = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            return guid.Substring(0, guid.Length-2);
        }
    }
}
