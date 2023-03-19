using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudyMash_MVC.Migrations
{
    /// <inheritdoc />
    public partial class addModelMakesv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Makes_MakeFK",
                table: "Models");

            migrationBuilder.RenameColumn(
                name: "MakeFK",
                table: "Models",
                newName: "MakeID");

            migrationBuilder.RenameIndex(
                name: "IX_Models_MakeFK",
                table: "Models",
                newName: "IX_Models_MakeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Makes_MakeID",
                table: "Models",
                column: "MakeID",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Makes_MakeID",
                table: "Models");

            migrationBuilder.RenameColumn(
                name: "MakeID",
                table: "Models",
                newName: "MakeFK");

            migrationBuilder.RenameIndex(
                name: "IX_Models_MakeID",
                table: "Models",
                newName: "IX_Models_MakeFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Makes_MakeFK",
                table: "Models",
                column: "MakeFK",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
