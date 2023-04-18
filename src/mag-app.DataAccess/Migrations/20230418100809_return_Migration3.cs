using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class return_Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReturnProducts_SaleGlobal_SaleGlobalId",
                table: "ReturnProducts");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnProducts_SaleGlobal_SaleGlobalId",
                table: "ReturnProducts",
                column: "SaleGlobalId",
                principalTable: "SaleGlobal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReturnProducts_SaleGlobal_SaleGlobalId",
                table: "ReturnProducts");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnProducts_SaleGlobal_SaleGlobalId",
                table: "ReturnProducts",
                column: "SaleGlobalId",
                principalTable: "SaleGlobal",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
