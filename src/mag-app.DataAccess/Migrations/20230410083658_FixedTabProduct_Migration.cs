using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class FixedTabProduct_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tabproducts_Products_ProductId",
                table: "Tabproducts");

            migrationBuilder.AddColumn<long>(
                name: "AllProductId",
                table: "Tabproducts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddForeignKey(
                name: "FK_Tabproducts_AllProducts_ProductId",
                table: "Tabproducts",
                column: "ProductId",
                principalTable: "AllProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tabproducts_AllProducts_ProductId",
                table: "Tabproducts");

            migrationBuilder.DropColumn(
                name: "AllProductId",
                table: "Tabproducts");

            migrationBuilder.AddForeignKey(
                name: "FK_Tabproducts_Products_ProductId",
                table: "Tabproducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
