using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastruct.Migrations
{
    /// <inheritdoc />
    public partial class creation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipes",
                columns: table => new
                {
                    EquipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdressLocal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipes", x => x.EquipeId);
                });

            migrationBuilder.CreateTable(
                name: "Membres",
                columns: table => new
                {
                    MembreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datenaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    identifiant = table.Column<int>(type: "int", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membres", x => x.MembreId);
                });

            migrationBuilder.CreateTable(
                name: "Trophes",
                columns: table => new
                {
                    TropheId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTrophee = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Recompense = table.Column<double>(type: "float", nullable: false),
                    TypeTrophee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trophes", x => x.TropheId);
                    table.ForeignKey(
                        name: "FK_Trophes_Equipes_EquipeId",
                        column: x => x.EquipeId,
                        principalTable: "Equipes",
                        principalColumn: "EquipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contrats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateContrat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DureeMois = table.Column<int>(type: "int", nullable: false),
                    salaire = table.Column<double>(type: "float", nullable: false),
                    MembreId = table.Column<int>(type: "int", nullable: false),
                    EquipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contrats_Equipes_EquipeId",
                        column: x => x.EquipeId,
                        principalTable: "Equipes",
                        principalColumn: "EquipeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contrats_Membres_MembreId",
                        column: x => x.MembreId,
                        principalTable: "Membres",
                        principalColumn: "MembreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_EquipeId",
                table: "Contrats",
                column: "EquipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_MembreId",
                table: "Contrats",
                column: "MembreId");

            migrationBuilder.CreateIndex(
                name: "IX_Trophes_EquipeId",
                table: "Trophes",
                column: "EquipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contrats");

            migrationBuilder.DropTable(
                name: "Trophes");

            migrationBuilder.DropTable(
                name: "Membres");

            migrationBuilder.DropTable(
                name: "Equipes");
        }
    }
}
