using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubcategoryName",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SubcategoryName",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "StoreId");

            migrationBuilder.AddColumn<long>(
                name: "EmployeeId",
                table: "SubCategories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "EmployeeId",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "EmployeeId",
                table: "Categories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
