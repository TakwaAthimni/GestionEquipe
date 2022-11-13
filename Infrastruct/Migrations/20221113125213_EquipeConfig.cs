using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastruct.Migrations
{
    /// <inheritdoc />
    public partial class EquipeConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contrats_Equipes_EquipeId",
                table: "Contrats");

            migrationBuilder.DropForeignKey(
                name: "FK_Trophes_Equipes_EquipeId",
                table: "Trophes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipes",
                table: "Equipes");

            migrationBuilder.RenameTable(
                name: "Equipes",
                newName: "MyEquipe");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "MyEquipe",
                newName: "EquipeLogo");

            migrationBuilder.AlterColumn<string>(
                name: "EquipeName",
                table: "MyEquipe",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyEquipe",
                table: "MyEquipe",
                column: "EquipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contrats_MyEquipe_EquipeId",
                table: "Contrats",
                column: "EquipeId",
                principalTable: "MyEquipe",
                principalColumn: "EquipeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trophes_MyEquipe_EquipeId",
                table: "Trophes",
                column: "EquipeId",
                principalTable: "MyEquipe",
                principalColumn: "EquipeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contrats_MyEquipe_EquipeId",
                table: "Contrats");

            migrationBuilder.DropForeignKey(
                name: "FK_Trophes_MyEquipe_EquipeId",
                table: "Trophes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyEquipe",
                table: "MyEquipe");

            migrationBuilder.RenameTable(
                name: "MyEquipe",
                newName: "Equipes");

            migrationBuilder.RenameColumn(
                name: "EquipeLogo",
                table: "Equipes",
                newName: "Logo");

            migrationBuilder.AlterColumn<string>(
                name: "EquipeName",
                table: "Equipes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipes",
                table: "Equipes",
                column: "EquipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contrats_Equipes_EquipeId",
                table: "Contrats",
                column: "EquipeId",
                principalTable: "Equipes",
                principalColumn: "EquipeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trophes_Equipes_EquipeId",
                table: "Trophes",
                column: "EquipeId",
                principalTable: "Equipes",
                principalColumn: "EquipeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
