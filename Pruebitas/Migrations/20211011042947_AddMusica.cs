using Microsoft.EntityFrameworkCore.Migrations;

namespace Pruebitas.Migrations
{
    public partial class AddMusica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musica",
                columns: table => new
                {
                    nombreCancion = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    autor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    letra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musica", x => x.nombreCancion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musica");
        }
    }
}
