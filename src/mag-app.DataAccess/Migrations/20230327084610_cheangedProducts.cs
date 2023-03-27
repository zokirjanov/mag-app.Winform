using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class cheangedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AllProducts",
                table: "AllProducts");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AllProducts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AllProducts",
                table: "AllProducts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AllProducts_StoreId",
                table: "AllProducts",
                column: "StoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AllProducts",
                table: "AllProducts");

            migrationBuilder.DropIndex(
                name: "IX_AllProducts_StoreId",
                table: "AllProducts");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "AllProducts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AllProducts",
                table: "AllProducts",
                columns: new[] { "StoreId", "ProductId" });
        }
    }
}
