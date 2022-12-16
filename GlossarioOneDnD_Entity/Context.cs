using GlossarioOneDnD_Entity.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlossarioOneDnD_Entity
{
    internal class Context : DbContext
    {
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Niveis> Niveis { get; set; }
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Niveis>()
                .HasOne<Classe>(n => n.Classe)
                .WithMany(c => c.Niveis)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Regra>()
                .HasOne<GlossarioRegras>(r => r.Glossario)
                .WithMany(g => g.Regras)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
