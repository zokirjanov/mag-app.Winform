using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class FixedMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleGlobal_AllProducts_ProductId",
                table: "SaleGlobal");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleGlobal_AllProducts_ProductId",
                table: "SaleGlobal",
                column: "ProductId",
                principalTable: "AllProducts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleGlobal_AllProducts_ProductId",
                table: "SaleGlobal");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleGlobal_AllProducts_ProductId",
                table: "SaleGlobal",
                column: "ProductId",
                principalTable: "AllProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
