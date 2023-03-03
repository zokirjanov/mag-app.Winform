using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class StoreCreateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "EmployeeId",
                table: "Stores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Stores");
        }
    }
}
