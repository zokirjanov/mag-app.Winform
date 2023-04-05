﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    public partial class TabProductMigration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tabproducts_Tabs_TabControllerId",
                table: "Tabproducts");

            migrationBuilder.AddForeignKey(
                name: "FK_Tabproducts_Tabs_TabControllerId",
                table: "Tabproducts",
                column: "TabControllerId",
                principalTable: "Tabs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tabproducts_Tabs_TabControllerId",
                table: "Tabproducts");

            migrationBuilder.AddForeignKey(
                name: "FK_Tabproducts_Tabs_TabControllerId",
                table: "Tabproducts",
                column: "TabControllerId",
                principalTable: "Tabs",
                principalColumn: "Id");
        }
    }
}