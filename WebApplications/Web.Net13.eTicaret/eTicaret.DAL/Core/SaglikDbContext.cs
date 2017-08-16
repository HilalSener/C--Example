using eTicaret.DAL.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaret.DAL.Core
{
    //System.Data.Entity için Manage Nuget Packages ile Entity Framework yüklenmeli.
    public class SaglikDbContext : DbContext 
    {
        public SaglikDbContext() : base("SaglikDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SaglikDbContext, Configuration>("SaglikDbContext"));
        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<AltKategori> AltKategoriler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<SatisDetay> SatisDetaylari { get; set; }
    }
}
