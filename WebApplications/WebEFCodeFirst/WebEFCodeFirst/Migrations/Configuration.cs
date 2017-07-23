namespace WebEFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebEFCodeFirst.DataModel.StokDataContext>
    {
        //CodeFirst modeli uygulanan projelerde, kod(ara katman) ile veritaban� aras�ndaki farkl�l�klar�n hata vermeden g�ncellenebilmesi i�in Migration s�n�f� olu�turulmal� ve y�netilmelidir.
        //�ncelikle Tools/Nuget Package Manager/Pachage Manager Console a �u komut yaz�lmal�r;
        //PM>enable-Migrations -EnableAutomaticMigration:$true
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true; //E�er veritaban� bo� de�ilse
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
