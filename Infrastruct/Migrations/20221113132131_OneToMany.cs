using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastruct.Migrations
{
    /// <inheritdoc />
    public partial class OneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trophes_MyEquipe_EquipeId",
                table: "Trophes");

            migrationBuilder.RenameColumn(
                name: "EquipeId",
                table: "Trophes",
                newName: "EquipeFK");

            migrationBuilder.RenameIndex(
                name: "IX_Trophes_EquipeId",
                table: "Trophes",
                newName: "IX_Trophes_EquipeFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Trophes_MyEquipe_EquipeFK",
                table: "Trophes",
                column: "EquipeFK",
                principalTable: "MyEquipe",
                principalColumn: "EquipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trophes_MyEquipe_EquipeFK",
                table: "Trophes");

            migrationBuilder.RenameColumn(
                name: "EquipeFK",
                table: "Trophes",
                newName: "EquipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Trophes_EquipeFK",
                table: "Trophes",
                newName: "IX_Trophes_EquipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trophes_MyEquipe_EquipeId",
                table: "Trophes",
                column: "EquipeId",
                principalTable: "MyEquipe",
                principalColumn: "EquipeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
