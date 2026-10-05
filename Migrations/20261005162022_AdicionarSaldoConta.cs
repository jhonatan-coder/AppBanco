using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppBanco.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarSaldoConta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Saldo",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Saldo",
                table: "Usuarios");
        }
    }
}
