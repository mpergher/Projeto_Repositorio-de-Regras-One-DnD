using Microsoft.EntityFrameworkCore;

namespace GlossarioOneDnD_MVC.Models
{
    public class Context : DbContext
    {
        //public DbSet<Classe> Classe { get; set; }
        //public DbSet<Niveis> Niveis { get; set; }
        public DbSet<GlossarioRegras> Glossario { get; set; }
        public DbSet<Regra> Regras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("" +
                "Data Source=localhost; " +
                "initial Catalog=GlossarioDnD;User ID=GlossarioDnD; " +
                "password=GlossarioDnD;language=Portuguese;Trusted_Connection=True;" +
                "TrustServerCertificate=True;");

            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
