using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleBar.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class AddTBMesa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "TBMesa",
                type: "varchar(250)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "TBMesa",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)");
        }
    }
}
