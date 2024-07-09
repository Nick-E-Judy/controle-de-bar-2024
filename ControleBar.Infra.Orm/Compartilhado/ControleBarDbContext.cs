using ControleBar.Dominio.ModuloGarcom;
using ControleBar.Dominio.ModuloMesa;
using ControleBar.Dominio.ModuloProduto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ControleBar.Infra.Orm.Compartilhado
{
    public class ControleBarDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Garcom> Garcons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
               "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ControleBarOrm;Integrated Security=True";

            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>(produtoBuilder =>
            {
                produtoBuilder.ToTable("TBProduto");

                produtoBuilder.Property(p => p.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                produtoBuilder.Property(p => p.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                produtoBuilder.Property(p => p.Preco)
                    .IsRequired()
                    .HasColumnType("DECIMAL");
            });

            modelBuilder.Entity<Mesa>(mesaBuilder =>
            {
                mesaBuilder.ToTable("TBMesa");

                mesaBuilder.Property(m => m.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                mesaBuilder.Property(m => m.Numero)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                mesaBuilder.Property(m => m.Ocupada)
                    .IsRequired()
                    .HasColumnType("bit");
            });

            modelBuilder.Entity<Garcom>(garcomBuilder =>
            {
                garcomBuilder.ToTable("TBGarcom");

                garcomBuilder.Property(p => p.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                garcomBuilder.Property(p => p.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(250)");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
