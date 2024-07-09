﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleBar.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class AddTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBGarcom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBGarcom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBMesa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(type: "varchar(250)", nullable: false),
                    Ocupada = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBMesa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Preco = table.Column<decimal>(type: "DECIMAL(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBProduto", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBGarcom");

            migrationBuilder.DropTable(
                name: "TBMesa");

            migrationBuilder.DropTable(
                name: "TBProduto");
        }
    }
}
