using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class Fixed_Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleDetails_AllProducts_ProductId",
                table: "SaleDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleDetails_SalesGlobals_SaleId",
                table: "SaleDetails");

            migrationBuilder.DropTable(
                name: "SalesGlobals");

            migrationBuilder.RenameColumn(
                name: "SaleId",
                table: "SaleDetails",
                newName: "StoreId");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "SaleDetails",
                newName: "change");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "SaleDetails",
                newName: "TransactionDate");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "SaleDetails",
                newName: "CashId");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "SaleDetails",
                newName: "TotalSalePrice");

            migrationBuilder.RenameIndex(
                name: "IX_SaleDetails_SaleId",
                table: "SaleDetails",
                newName: "IX_SaleDetails_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_SaleDetails_ProductId",
                table: "SaleDetails",
                newName: "IX_SaleDetails_CashId");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountPrice",
                table: "SaleDetails",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "StoreId",
                table: "SaleDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 11)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "change",
                table: "SaleDetails",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "SaleDetails",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 10)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "CashId",
                table: "SaleDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalSalePrice",
                table: "SaleDetails",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AddColumn<decimal>(
                name: "CardAmount",
                table: "SaleDetails",
                type: "TEXT",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AddColumn<decimal>(
                name: "CashAmount",
                table: "SaleDetails",
                type: "TEXT",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<string>(
                name: "CashName",
                table: "SaleDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "PaymentType",
                table: "SaleDetails",
                type: "TEXT",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AddColumn<string>(
                name: "StoreName",
                table: "SaleDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 12);

            migrationBuilder.CreateTable(
                name: "SaleGlobal",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SaleId = table.Column<long>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<long>(type: "INTEGER", nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleGlobal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleGlobal_AllProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "AllProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_SaleGlobal_SaleDetails_SaleId",
                        column: x => x.SaleId,
                        principalTable: "SaleDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_PaymentType",
                table: "SaleDetails",
                column: "PaymentType");

            migrationBuilder.CreateIndex(
                name: "IX_SaleGlobal_ProductId",
                table: "SaleGlobal",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleGlobal_SaleId",
                table: "SaleGlobal",
                column: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleDetails_Cashes_CashId",
                table: "SaleDetails",
                column: "CashId",
                principalTable: "Cashes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleDetails_Stores_StoreId",
                table: "SaleDetails",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleDetails_Cashes_CashId",
                table: "SaleDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleDetails_Stores_StoreId",
                table: "SaleDetails");

            migrationBuilder.DropTable(
                name: "SaleGlobal");

            migrationBuilder.DropIndex(
                name: "IX_SaleDetails_PaymentType",
                table: "SaleDetails");

            migrationBuilder.DropColumn(
                name: "CardAmount",
                table: "SaleDetails");

            migrationBuilder.DropColumn(
                name: "CashAmount",
                table: "SaleDetails");

            migrationBuilder.DropColumn(
                name: "CashName",
                table: "SaleDetails");

            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "SaleDetails");

            migrationBuilder.DropColumn(
                name: "StoreName",
                table: "SaleDetails");

            migrationBuilder.RenameColumn(
                name: "change",
                table: "SaleDetails",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "TransactionDate",
                table: "SaleDetails",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "TotalSalePrice",
                table: "SaleDetails",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "SaleDetails",
                newName: "SaleId");

            migrationBuilder.RenameColumn(
                name: "CashId",
                table: "SaleDetails",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_SaleDetails_StoreId",
                table: "SaleDetails",
                newName: "IX_SaleDetails_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_SaleDetails_CashId",
                table: "SaleDetails",
                newName: "IX_SaleDetails_ProductId");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountPrice",
                table: "SaleDetails",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "SaleDetails",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "SaleDetails",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "SaleDetails",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "SaleId",
                table: "SaleDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "SaleDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.CreateTable(
                name: "SalesGlobals",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CashId = table.Column<long>(type: "INTEGER", nullable: false),
                    CashName = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentType = table.Column<string>(type: "TEXT", nullable: true),
                    CashAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    CardAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    TotalSalePrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    change = table.Column<decimal>(type: "TEXT", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "TEXT", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StoreId = table.Column<long>(type: "INTEGER", nullable: false),
                    StoreName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesGlobals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesGlobals_Cashes_CashId",
                        column: x => x.CashId,
                        principalTable: "Cashes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesGlobals_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesGlobals_CashId",
                table: "SalesGlobals",
                column: "CashId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesGlobals_PaymentType",
                table: "SalesGlobals",
                column: "PaymentType");

            migrationBuilder.CreateIndex(
                name: "IX_SalesGlobals_StoreId",
                table: "SalesGlobals",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleDetails_AllProducts_ProductId",
                table: "SaleDetails",
                column: "ProductId",
                principalTable: "AllProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleDetails_SalesGlobals_SaleId",
                table: "SaleDetails",
                column: "SaleId",
                principalTable: "SalesGlobals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
