using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class SaleMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardAmount",
                table: "SaleDetails");

            migrationBuilder.DropColumn(
                name: "CashAmount",
                table: "SaleDetails");

            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "SaleDetails");

            migrationBuilder.AddColumn<decimal>(
                name: "CardAmount",
                table: "SalesGlobals",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CashAmount",
                table: "SalesGlobals",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentType",
                table: "SalesGlobals",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardAmount",
                table: "SalesGlobals");

            migrationBuilder.DropColumn(
                name: "CashAmount",
                table: "SalesGlobals");

            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "SalesGlobals");

            migrationBuilder.AddColumn<decimal>(
                name: "CardAmount",
                table: "SaleDetails",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CashAmount",
                table: "SaleDetails",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentType",
                table: "SaleDetails",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
