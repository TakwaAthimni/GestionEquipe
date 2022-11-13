using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastruct.Migrations
{
    /// <inheritdoc />
    public partial class TPT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Membres");

            migrationBuilder.DropColumn(
                name: "IsJoueur",
                table: "Membres");

            migrationBuilder.CreateTable(
                name: "Entraineur",
                columns: table => new
                {
                    MembreId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entraineur", x => x.MembreId);
                    table.ForeignKey(
                        name: "FK_Entraineur_Membres_MembreId",
                        column: x => x.MembreId,
                        principalTable: "Membres",
                        principalColumn: "MembreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Joueur",
                columns: table => new
                {
                    MembreId = table.Column<int>(type: "int", nullable: false),
                    Poste = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joueur", x => x.MembreId);
                    table.ForeignKey(
                        name: "FK_Joueur_Membres_MembreId",
                        column: x => x.MembreId,
                        principalTable: "Membres",
                        principalColumn: "MembreId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entraineur");

            migrationBuilder.DropTable(
                name: "Joueur");

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Membres",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsJoueur",
                table: "Membres",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
