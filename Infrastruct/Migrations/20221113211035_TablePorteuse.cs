using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastruct.Migrations
{
    /// <inheritdoc />
    public partial class TablePorteuse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contrats_Membres_MembreId",
                table: "Contrats");

            migrationBuilder.DropForeignKey(
                name: "FK_Contrats_MyEquipe_EquipeId",
                table: "Contrats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contrats",
                table: "Contrats");

            migrationBuilder.DropIndex(
                name: "IX_Contrats_EquipeId",
                table: "Contrats");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Contrats");

            migrationBuilder.RenameColumn(
                name: "MembreId",
                table: "Contrats",
                newName: "membreFK");

            migrationBuilder.RenameColumn(
                name: "EquipeId",
                table: "Contrats",
                newName: "equipeFK");

            migrationBuilder.RenameIndex(
                name: "IX_Contrats_MembreId",
                table: "Contrats",
                newName: "IX_Contrats_membreFK");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contrats",
                table: "Contrats",
                columns: new[] { "equipeFK", "membreFK" });

            migrationBuilder.AddForeignKey(
                name: "FK_Contrats_Membres_membreFK",
                table: "Contrats",
                column: "membreFK",
                principalTable: "Membres",
                principalColumn: "MembreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contrats_MyEquipe_equipeFK",
                table: "Contrats",
                column: "equipeFK",
                principalTable: "MyEquipe",
                principalColumn: "EquipeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contrats_Membres_membreFK",
                table: "Contrats");

            migrationBuilder.DropForeignKey(
                name: "FK_Contrats_MyEquipe_equipeFK",
                table: "Contrats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contrats",
                table: "Contrats");

            migrationBuilder.RenameColumn(
                name: "membreFK",
                table: "Contrats",
                newName: "MembreId");

            migrationBuilder.RenameColumn(
                name: "equipeFK",
                table: "Contrats",
                newName: "EquipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Contrats_membreFK",
                table: "Contrats",
                newName: "IX_Contrats_MembreId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Contrats",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contrats",
                table: "Contrats",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_EquipeId",
                table: "Contrats",
                column: "EquipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contrats_Membres_MembreId",
                table: "Contrats",
                column: "MembreId",
                principalTable: "Membres",
                principalColumn: "MembreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contrats_MyEquipe_EquipeId",
                table: "Contrats",
                column: "EquipeId",
                principalTable: "MyEquipe",
                principalColumn: "EquipeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
