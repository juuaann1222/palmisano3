using Microsoft.EntityFrameworkCore.Migrations;

namespace PalmisanoPromicion.Migrations
{
    public partial class PalmisanoPromicion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_peliculasActores_Peliculas_PeliculasId",
                table: "peliculasActores");

            migrationBuilder.DropForeignKey(
                name: "FK_peliculasActores_Personas_PersonasId",
                table: "peliculasActores");

            migrationBuilder.DropIndex(
                name: "IX_peliculasActores_PeliculasId",
                table: "peliculasActores");

            migrationBuilder.DropIndex(
                name: "IX_peliculasActores_PersonasId",
                table: "peliculasActores");

            migrationBuilder.DropColumn(
                name: "PeliculasId",
                table: "peliculasActores");

            migrationBuilder.DropColumn(
                name: "PersonasId",
                table: "peliculasActores");

            migrationBuilder.CreateIndex(
                name: "IX_peliculasActores_PersonaId",
                table: "peliculasActores",
                column: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_peliculasActores_Peliculas_PeliculaId",
                table: "peliculasActores",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_peliculasActores_Personas_PersonaId",
                table: "peliculasActores",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_peliculasActores_Peliculas_PeliculaId",
                table: "peliculasActores");

            migrationBuilder.DropForeignKey(
                name: "FK_peliculasActores_Personas_PersonaId",
                table: "peliculasActores");

            migrationBuilder.DropIndex(
                name: "IX_peliculasActores_PersonaId",
                table: "peliculasActores");

            migrationBuilder.AddColumn<int>(
                name: "PeliculasId",
                table: "peliculasActores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonasId",
                table: "peliculasActores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_peliculasActores_PeliculasId",
                table: "peliculasActores",
                column: "PeliculasId");

            migrationBuilder.CreateIndex(
                name: "IX_peliculasActores_PersonasId",
                table: "peliculasActores",
                column: "PersonasId");

            migrationBuilder.AddForeignKey(
                name: "FK_peliculasActores_Peliculas_PeliculasId",
                table: "peliculasActores",
                column: "PeliculasId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_peliculasActores_Personas_PersonasId",
                table: "peliculasActores",
                column: "PersonasId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
