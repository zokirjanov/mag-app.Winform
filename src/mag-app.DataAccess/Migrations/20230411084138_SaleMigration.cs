using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class SaleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesGlobals",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TotalSale = table.Column<decimal>(type: "TEXT", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StoreId = table.Column<long>(type: "INTEGER", nullable: false),
                    StoreName = table.Column<string>(type: "TEXT", nullable: false),
                    CashId = table.Column<long>(type: "INTEGER", nullable: false),
                    CashName = table.Column<string>(type: "TEXT", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "SaleDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SaleId = table.Column<long>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<long>(type: "INTEGER", nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "TEXT", nullable: true),
                    PaymentType = table.Column<int>(type: "INTEGER", nullable: false),
                    CashAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    CardAmount = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleDetails_AllProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "AllProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_SaleDetails_SalesGlobals_SaleId",
                        column: x => x.SaleId,
                        principalTable: "SalesGlobals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_ProductId",
                table: "SaleDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_SaleId",
                table: "SaleDetails",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesGlobals_CashId",
                table: "SalesGlobals",
                column: "CashId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesGlobals_StoreId",
                table: "SalesGlobals",
                column: "StoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleDetails");

            migrationBuilder.DropTable(
                name: "SalesGlobals");
        }
    }
}
