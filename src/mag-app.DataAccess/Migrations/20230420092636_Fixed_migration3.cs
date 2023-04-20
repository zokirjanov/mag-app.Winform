using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class Fixed_migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "IsReturned",
                table: "SaleGlobal",
                type: "INTEGER",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 12);

            migrationBuilder.AddColumn<long>(
                name: "IsReturned",
                table: "SaleDetails",
                type: "INTEGER",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 14);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReturned",
                table: "SaleGlobal");

            migrationBuilder.DropColumn(
                name: "IsReturned",
                table: "SaleDetails");
        }
    }
}
