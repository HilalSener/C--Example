namespace WebEFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebEFCodeFirst.DataModel.StokDataContext>
    {
        //CodeFirst modeli uygulanan projelerde, kod(ara katman) ile veritabaný arasýndaki farklýlýklarýn hata vermeden güncellenebilmesi için Migration sýnýfý oluþturulmalý ve yönetilmelidir.
        //Öncelikle Tools/Nuget Package Manager/Pachage Manager Console a þu komut yazýlmalýr;
        //PM>enable-Migrations -EnableAutomaticMigration:$true
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true; //Eðer veritabaný boþ deðilse
            ContextKey = "WebEFCodeFirst.DataModel.StokDataContext";
        }

        protected override void Seed(WebEFCodeFirst.DataModel.StokDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
