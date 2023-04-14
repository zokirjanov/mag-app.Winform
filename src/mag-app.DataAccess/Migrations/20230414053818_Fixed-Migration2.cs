using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class FixedMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "SaleId",
                table: "SaleGlobal",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "SaleGlobal",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "SaleGlobal",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "SaleGlobal",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "SaleGlobal",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountPrice",
                table: "SaleGlobal",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AddColumn<string>(
                name: "Barcode",
                table: "SaleGlobal",
                type: "TEXT",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "SaleGlobal");

            migrationBuilder.AlterColumn<long>(
                name: "SaleId",
                table: "SaleGlobal",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "SaleGlobal",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "SaleGlobal",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "SaleGlobal",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "SaleGlobal",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT")
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountPrice",
                table: "SaleGlobal",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 8);
        }
    }
}
