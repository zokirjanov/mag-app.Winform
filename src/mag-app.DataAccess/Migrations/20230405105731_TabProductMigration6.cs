using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class TabProductMigration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tabproducts_Products_ProductId",
                table: "Tabproducts");

            migrationBuilder.AddForeignKey(
                name: "FK_Tabproducts_Products_ProductId",
                table: "Tabproducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tabproducts_Products_ProductId",
                table: "Tabproducts");

            migrationBuilder.AddForeignKey(
                name: "FK_Tabproducts_Products_ProductId",
                table: "Tabproducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
