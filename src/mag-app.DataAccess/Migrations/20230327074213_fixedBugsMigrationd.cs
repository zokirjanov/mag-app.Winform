using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class fixedBugsMigrationd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AllProducts_Products_StoreId",
                table: "AllProducts");

            migrationBuilder.CreateIndex(
                name: "IX_AllProducts_ProductId",
                table: "AllProducts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_AllProducts_Products_ProductId",
                table: "AllProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AllProducts_Products_ProductId",
                table: "AllProducts");

            migrationBuilder.DropIndex(
                name: "IX_AllProducts_ProductId",
                table: "AllProducts");

            migrationBuilder.AddForeignKey(
                name: "FK_AllProducts_Products_StoreId",
                table: "AllProducts",
                column: "StoreId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
