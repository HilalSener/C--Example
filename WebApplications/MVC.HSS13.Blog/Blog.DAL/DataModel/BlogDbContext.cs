using Blog.DAL.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.DataModel
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext() : base("BlogDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogDbContext, Configuration>("BlogDbContext"));
        }

        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Makale> Makaleler { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
        public DbSet<Etiket> Etiketler { get; set; }
    }
}
