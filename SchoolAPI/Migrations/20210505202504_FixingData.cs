using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class FixingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fcea7bf-d4ca-4fdb-b000-ce2e879b1e87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afa85608-04dd-43d4-9ebc-2c16319451fd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f8b4060-f0b5-4320-a8bc-6e69e0b06da8", "aac32142-0b52-405d-8169-8c00f750af2c", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "494353ee-bbbb-4ec0-83e8-c471f8163b2b", "00d218e7-0b72-46bf-bc31-c7a73eba60e2", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "494353ee-bbbb-4ec0-83e8-c471f8163b2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f8b4060-f0b5-4320-a8bc-6e69e0b06da8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "afa85608-04dd-43d4-9ebc-2c16319451fd", "1e94a2cc-5c42-4f78-b4dc-b0f61698f2b0", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3fcea7bf-d4ca-4fdb-b000-ce2e879b1e87", "cfca8d63-eb55-43f5-a95b-1e12789a280c", "Administrator", "ADMINISTRATOR" });
        }
    }
}
