using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infnet.EasyMediaLibrary.ConsoleApp.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Midias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Titulo = table.Column<string>(type: "TEXT", nullable: false),
                    DuracaoMinutos = table.Column<int>(type: "INTEGER", nullable: false),
                    Ano = table.Column<int>(type: "INTEGER", nullable: false),
                    Genero = table.Column<string>(type: "TEXT", nullable: false),
                    TipoMidia = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    Diretor = table.Column<string>(type: "TEXT", nullable: true),
                    ClassificacaoIndicativa = table.Column<string>(type: "TEXT", nullable: true),
                    Artista = table.Column<string>(type: "TEXT", nullable: true),
                    Album = table.Column<string>(type: "TEXT", nullable: true),
                    Apresentador = table.Column<string>(type: "TEXT", nullable: true),
                    Convidados = table.Column<string>(type: "TEXT", nullable: true),
                    NumeroTemporadas = table.Column<int>(type: "INTEGER", nullable: true),
                    EpisodiosPorTemporada = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Midias", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Midias");
        }
    }
}
