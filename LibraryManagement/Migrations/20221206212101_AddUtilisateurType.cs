using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Migrations
{
    public partial class AddUtilisateurType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Utilisateurs",
                newName: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_Type",
                table: "Utilisateurs",
                column: "Type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Utilisateurs_Type",
                table: "Utilisateurs");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Utilisateurs",
                newName: "Discriminator");
        }
    }
}
