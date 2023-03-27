using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class FixedProductsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AllProducts",
                table: "AllProducts");

            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "AllProducts");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "AllProducts");

            migrationBuilder.DropColumn(
                name: "ProdutName",
                table: "AllProducts");

            migrationBuilder.DropColumn(
                name: "PurchasedPrice",
                table: "AllProducts");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AllProducts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<long>(
                name: "ProductId",
                table: "AllProducts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AllProducts",
                table: "AllProducts",
                columns: new[] { "StoreId", "ProductId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AllProducts_Products_StoreId",
                table: "AllProducts",
                column: "StoreId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AllProducts_Stores_StoreId",
                table: "AllProducts",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AllProducts_Products_StoreId",
                table: "AllProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_AllProducts_Stores_StoreId",
                table: "AllProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AllProducts",
                table: "AllProducts");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "AllProducts");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AllProducts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Barcode",
                table: "AllProducts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "AllProducts",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ProdutName",
                table: "AllProducts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "PurchasedPrice",
                table: "AllProducts",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AllProducts",
                table: "AllProducts",
                column: "Id");
        }
    }
}
