using Microsoft.EntityFrameworkCore.Migrations;

namespace Pruebitas.Migrations
{
    public partial class AddMusi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Musica",
                table: "Musica");

            migrationBuilder.AlterColumn<string>(
                name: "autor",
                table: "Musica",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombreCancion",
                table: "Musica",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musica",
                table: "Musica",
                column: "autor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Musica",
                table: "Musica");

            migrationBuilder.AlterColumn<string>(
                name: "nombreCancion",
                table: "Musica",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "autor",
                table: "Musica",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musica",
                table: "Musica",
                column: "nombreCancion");
        }
    }
}
