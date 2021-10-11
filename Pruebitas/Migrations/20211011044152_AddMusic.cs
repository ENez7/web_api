using Microsoft.EntityFrameworkCore.Migrations;

namespace Pruebitas.Migrations
{
    public partial class AddMusic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "mancos",
                table: "Musica",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "mancos",
                table: "Musica");
        }
    }
}
