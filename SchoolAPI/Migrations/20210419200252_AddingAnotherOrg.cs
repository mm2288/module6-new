using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class AddingAnotherOrg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "OrganizationId", "OrgName" },
                values: new object[] { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce4"), "megan's org" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce4"));
        }
    }
}
