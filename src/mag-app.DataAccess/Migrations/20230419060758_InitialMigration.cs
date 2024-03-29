﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StoreName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tabs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TabName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Login = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    Salt = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubCategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<long>(type: "INTEGER", nullable: false),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cashes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StoreId = table.Column<long>(type: "INTEGER", nullable: false),
                    StoreName = table.Column<string>(type: "TEXT", nullable: false),
                    CashName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cashes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cashes_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Barcode = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<long>(type: "INTEGER", nullable: false),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    SubCategoryId = table.Column<long>(type: "INTEGER", nullable: false),
                    SubCategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    ProdutName = table.Column<string>(type: "TEXT", nullable: false),
                    PurchasedPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CheckNumber = table.Column<string>(type: "TEXT", nullable: false),
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
                    table.PrimaryKey("PK_SaleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleDetails_Cashes_CashId",
                        column: x => x.CashId,
                        principalTable: "Cashes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleDetails_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "AllProducts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Barcode = table.Column<string>(type: "TEXT", nullable: false),
                    StoreId = table.Column<long>(type: "INTEGER", nullable: true),
                    StoreName = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<long>(type: "INTEGER", nullable: false),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    SubCategoryId = table.Column<long>(type: "INTEGER", nullable: true),
                    SubCategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<long>(type: "INTEGER", nullable: false),
                    ProdutName = table.Column<string>(type: "TEXT", nullable: false),
                    PurchasedPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AllProducts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllProducts_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_AllProducts_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleGlobal",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Barcode = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    SubCategory = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<long>(type: "INTEGER", nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    SaleId = table.Column<long>(type: "INTEGER", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Tabproducts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Barcode = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Subcategory = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId = table.Column<long>(type: "INTEGER", nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    TabControllerId = table.Column<long>(type: "INTEGER", nullable: false),
                    TabControllerName = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabproducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tabproducts_AllProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "AllProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tabproducts_Tabs_TabControllerId",
                        column: x => x.TabControllerId,
                        principalTable: "Tabs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnProducts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Barcode = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    SubCategory = table.Column<string>(type: "TEXT", nullable: false),
                    SaleGlobalId = table.Column<long>(type: "INTEGER", nullable: false),
                    SgName = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: false),
                    ReturnedPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnProducts_SaleGlobal_SaleGlobalId",
                        column: x => x.SaleGlobalId,
                        principalTable: "SaleGlobal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllProducts_CategoryId",
                table: "AllProducts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AllProducts_ProductId",
                table: "AllProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AllProducts_StoreId",
                table: "AllProducts",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_AllProducts_SubCategoryId",
                table: "AllProducts",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cashes_StoreId",
                table: "Cashes",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnProducts_SaleGlobalId",
                table: "ReturnProducts",
                column: "SaleGlobalId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_CashId",
                table: "SaleDetails",
                column: "CashId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_PaymentType",
                table: "SaleDetails",
                column: "PaymentType");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_StoreId",
                table: "SaleDetails",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleGlobal_ProductId",
                table: "SaleGlobal",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleGlobal_SaleId",
                table: "SaleGlobal",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabproducts_ProductId",
                table: "Tabproducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabproducts_TabControllerId",
                table: "Tabproducts",
                column: "TabControllerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReturnProducts");

            migrationBuilder.DropTable(
                name: "Tabproducts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SaleGlobal");

            migrationBuilder.DropTable(
                name: "Tabs");

            migrationBuilder.DropTable(
                name: "AllProducts");

            migrationBuilder.DropTable(
                name: "SaleDetails");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Cashes");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
