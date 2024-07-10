using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleBar.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class AddTBConta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContaId",
                table: "TBMesa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TBConta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Aberta = table.Column<bool>(type: "bit", nullable: false),
                    DataAbertura = table.Column<DateTime>(type: "datetime", nullable: false),
                    Garcom_Id = table.Column<int>(type: "int", nullable: false),
                    Mesa_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBConta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBConta_TBGarcom",
                        column: x => x.Garcom_Id,
                        principalTable: "TBGarcom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBConta_TBMesa",
                        column: x => x.Mesa_Id,
                        principalTable: "TBMesa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBPedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Produto_Id = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pedido_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBPedido_TBConta",
                        column: x => x.Pedido_Id,
                        principalTable: "TBConta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBPedido_TBProduto",
                        column: x => x.Produto_Id,
                        principalTable: "TBProduto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBMesa_ContaId",
                table: "TBMesa",
                column: "ContaId");

            migrationBuilder.CreateIndex(
                name: "IX_TBConta_Garcom_Id",
                table: "TBConta",
                column: "Garcom_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TBConta_Mesa_Id",
                table: "TBConta",
                column: "Mesa_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TBPedido_Pedido_Id",
                table: "TBPedido",
                column: "Pedido_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TBPedido_Produto_Id",
                table: "TBPedido",
                column: "Produto_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBMesa_TBConta_ContaId",
                table: "TBMesa");

            migrationBuilder.DropTable(
                name: "TBPedido");

            migrationBuilder.DropTable(
                name: "TBConta");

            migrationBuilder.DropIndex(
                name: "IX_TBMesa_ContaId",
                table: "TBMesa");

            migrationBuilder.DropColumn(
                name: "ContaId",
                table: "TBMesa");
        }
    }
}
