using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuctionServerSide.Data.Migrations
{
    public partial class imageUpload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "photo",
                table: "Auctions",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "photo",
                table: "Auctions");
        }
    }
}
