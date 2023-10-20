using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using WebApp1.Models;

namespace WebApp1.Repository
{
    public class RepositoryBaglantisi : DbContext
    {
        public RepositoryBaglantisi(DbContextOptions apt) : base(apt)
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB,Database=Stok_Takip_uygulama_db;Trusted_Connection= true");

            public DbSetz<Product> (Products get; set; )
             }
        }
    }
}




