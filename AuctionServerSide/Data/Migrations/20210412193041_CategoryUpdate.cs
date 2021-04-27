using Microsoft.EntityFrameworkCore.Migrations;

namespace AuctionServerSide.Data.Migrations
{
    public partial class CategoryUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_CategoryID",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Categories",
                newName: "ParentCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_CategoryID",
                table: "Categories",
                newName: "IX_Categories_ParentCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_ParentCategoryID",
                table: "Categories",
                column: "ParentCategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_ParentCategoryID",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "ParentCategoryID",
                table: "Categories",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_ParentCategoryID",
                table: "Categories",
                newName: "IX_Categories_CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_CategoryID",
                table: "Categories",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
