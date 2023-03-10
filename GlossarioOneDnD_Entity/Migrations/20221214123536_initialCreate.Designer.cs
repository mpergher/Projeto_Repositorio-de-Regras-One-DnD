// <auto-generated />
using GlossarioOneDnD_Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GlossarioOneDnDEntity.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221214123536_initialCreate")]
    partial class initialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GlossarioOneDnD_Entity.DataModels.Classe", b =>
                {
                    b.Property<int>("ClasseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClasseID"));

                    b.Property<string>("ClasseNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClasseID");

                    b.ToTable("Classe");
                });

            modelBuilder.Entity("GlossarioOneDnD_Entity.DataModels.GlossarioRegras", b =>
                {
                    b.Property<int>("GlossarioRegrasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GlossarioRegrasId"));

                    b.Property<string>("Versao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GlossarioRegrasId");

                    b.ToTable("Glossario");
                });

            modelBuilder.Entity("GlossarioOneDnD_Entity.DataModels.Niveis", b =>
                {
                    b.Property<int>("NiveisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NiveisID"));

                    b.Property<int>("ClasseID")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VersoesAnteriores")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NiveisID");

                    b.HasIndex("ClasseID");

                    b.ToTable("Niveis");
                });

            modelBuilder.Entity("GlossarioOneDnD_Entity.DataModels.Regra", b =>
                {
                    b.Property<int>("RegraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegraId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GlossarioRegrasId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VersoesAnteriores")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegraId");

                    b.HasIndex("GlossarioRegrasId");

                    b.ToTable("Regras");
                });

            modelBuilder.Entity("GlossarioOneDnD_Entity.DataModels.Niveis", b =>
                {
                    b.HasOne("GlossarioOneDnD_Entity.DataModels.Classe", "Classe")
                        .WithMany("Niveis")
                        .HasForeignKey("ClasseID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Classe");
                });

            modelBuilder.Entity("GlossarioOneDnD_Entity.DataModels.Regra", b =>
                {
                    b.HasOne("GlossarioOneDnD_Entity.DataModels.GlossarioRegras", "Glossario")
                        .WithMany("Regras")
                        .HasForeignKey("GlossarioRegrasId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Glossario");
                });

            modelBuilder.Entity("GlossarioOneDnD_Entity.DataModels.Classe", b =>
                {
                    b.Navigation("Niveis");
                });

            modelBuilder.Entity("GlossarioOneDnD_Entity.DataModels.GlossarioRegras", b =>
                {
                    b.Navigation("Regras");
                });
#pragma warning restore 612, 618
        }
    }
}
