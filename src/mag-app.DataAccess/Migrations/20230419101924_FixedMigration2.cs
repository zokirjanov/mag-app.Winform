using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class FixedMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleGlobal_AllProducts_ProductId",
                table: "SaleGlobal");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "SaleGlobal",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleGlobal_AllProducts_ProductId",
                table: "SaleGlobal",
                column: "ProductId",
                principalTable: "AllProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleGlobal_AllProducts_ProductId",
                table: "SaleGlobal");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "SaleGlobal",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleGlobal_AllProducts_ProductId",
                table: "SaleGlobal",
                column: "ProductId",
                principalTable: "AllProducts",
                principalColumn: "Id");
        }
    }
}
