using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class SaleMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalSale",
                table: "SalesGlobals",
                newName: "TotalSalePrice");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "SalesGlobals",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "StoreName",
                table: "SalesGlobals",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "StoreId",
                table: "SalesGlobals",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentType",
                table: "SalesGlobals",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "CashName",
                table: "SalesGlobals",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<long>(
                name: "CashId",
                table: "SalesGlobals",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "CashAmount",
                table: "SalesGlobals",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<decimal>(
                name: "CardAmount",
                table: "SalesGlobals",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "SalesGlobals",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 1)
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalSalePrice",
                table: "SalesGlobals",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "SaleId",
                table: "SaleDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "SaleDetails",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "SaleDetails",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "SaleDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "SaleDetails",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountPrice",
                table: "SaleDetails",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "SaleDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 1)
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalSalePrice",
                table: "SalesGlobals",
                newName: "TotalSale");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "SalesGlobals",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT")
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<string>(
                name: "StoreName",
                table: "SalesGlobals",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<long>(
                name: "StoreId",
                table: "SalesGlobals",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentType",
                table: "SalesGlobals",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "CashName",
                table: "SalesGlobals",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<long>(
                name: "CashId",
                table: "SalesGlobals",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "CashAmount",
                table: "SalesGlobals",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<decimal>(
                name: "CardAmount",
                table: "SalesGlobals",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "SalesGlobals",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalSale",
                table: "SalesGlobals",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT")
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<long>(
                name: "SaleId",
                table: "SaleDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "SaleDetails",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "SaleDetails",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "SaleDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "SaleDetails",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT")
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountPrice",
                table: "SaleDetails",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "SaleDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Relational:ColumnOrder", 1)
                .OldAnnotation("Sqlite:Autoincrement", true);
        }
    }
}
