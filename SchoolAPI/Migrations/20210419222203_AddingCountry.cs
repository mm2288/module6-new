using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class AddingCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                columns: new[] { "City", "Country" },
                values: new object[] { "Lusaka", "ZM" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce4"),
                columns: new[] { "City", "Country" },
                values: new object[] { "New York", "USA" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                columns: new[] { "City", "Country" },
                values: new object[] { "Bloomfield", "USA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Organizations");
        }
    }
}
