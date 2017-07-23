using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebEFCodeFirst.Migrations;

namespace WebEFCodeFirst.DataModel
{
    //Oluşturulacak veritabanının bilgilerini Web.Config - ConnectionString içerisinde belirtmeliyiz. Dikkat etmemiz gereken nokta; add name olarak ara katmanın (DbContext - StokDataContext) ismini kullanmalıyız.
    public class StokDataContext : DbContext //System.Data.Entity sınıfı için Entity Framework dll'lerinin Manage Nuget Packages üzerinden eklenmesi gerekir.
    {
        public StokDataContext() : base("StokDataContext")
        {
            //Migration işlemleri için DBContext(StokDataContext) ile Migration sınıfı eşleştirilmelidir.
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StokDataContext, Configuration> ("StokDataContext"));
            this.Configuration.LazyLoadingEnabled = false;
        }

        //Veritabanımızda oluşmasını istediğimiz tablolara karşılık gelmek üzere tüm sınıflarımızı DBSet içerisinde çağırmalıyız.
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<AltKategori> AltKategoriler { get; set; }
    }
}