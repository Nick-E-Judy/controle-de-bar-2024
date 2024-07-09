﻿// <auto-generated />
using ControleBar.Infra.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleBar.Infra.Orm.Migrations
{
    [DbContext(typeof(ControleBarDbContext))]
    [Migration("20240709170628_Add TBProduto")]
    partial class AddTBProduto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ControleBar.Dominio.ModuloProduto.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("DECIMAL");

                    b.HasKey("Id");

                    b.ToTable("TBProduto", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
