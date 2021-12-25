using Microsoft.EntityFrameworkCore.Migrations;

namespace PalmisanoPromicion.Migrations
{
    public partial class PeliculasColumna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peliculas_Genero_GeneroId",
                table: "Peliculas");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.AddColumn<string>(
                name: "Autores",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Peliculas_Generos_GeneroId",
                table: "Peliculas",
                column: "GeneroId",
                principalTable: "Generos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peliculas_Generos_GeneroId",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "Autores",
                table: "Peliculas");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    TempId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.UniqueConstraint("AK_Genero_TempId", x => x.TempId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Peliculas_Genero_GeneroId",
                table: "Peliculas",
                column: "GeneroId",
                principalTable: "Genero",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
