using Microsoft.EntityFrameworkCore.Migrations;

namespace PalmisanoPromicion.Migrations
{
    public partial class PeliculaPrueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Autores",
                table: "Peliculas",
                newName: "FotoActores");

            migrationBuilder.AddColumn<int>(
                name: "Actores",
                table: "Peliculas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_peliculasActores_PeliculaId",
                table: "peliculasActores",
                column: "PeliculaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_peliculasActores_PeliculaId",
                table: "peliculasActores");

            migrationBuilder.DropColumn(
                name: "Actores",
                table: "Peliculas");

            migrationBuilder.RenameColumn(
                name: "FotoActores",
                table: "Peliculas",
                newName: "Autores");
        }
    }
}
