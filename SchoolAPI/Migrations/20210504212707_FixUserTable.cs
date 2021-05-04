using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class FixUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "200918c0-2cc1-46ba-bd3f-85ed79c8f740");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38117b0c-7997-4763-bb76-5ba604bc73d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1772724e-94fc-4bb1-8d3a-568f6bf05be4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd5731ae-aff2-4164-8834-5c77e7e72ba9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0cbfcfa-9e04-49f5-b49d-eb6cf452f95a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6f44ed3-9cb3-40b2-9c7c-c941cbdf04c2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac9a9ae0-d071-43a9-8645-9df853064e41", "c6b81471-4d7e-4072-88bf-b2ff8f143a4b", "manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "731e2cd9-e860-4ef3-8cc6-96d631e1c6f8", "cef7104f-e351-4ba9-a377-b956c8768bd3", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "731e2cd9-e860-4ef3-8cc6-96d631e1c6f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac9a9ae0-d071-43a9-8645-9df853064e41");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38117b0c-7997-4763-bb76-5ba604bc73d0", "e5ee7a3b-0ec4-4aa2-b963-36e392da020c", "manager", "MANAGER" },
                    { "200918c0-2cc1-46ba-bd3f-85ed79c8f740", "a80d13cf-c396-47e5-99d5-858f9d082f7e", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OrganizationId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[,]
                {
                    { "d0cbfcfa-9e04-49f5-b49d-eb6cf452f95a", 0, "ac8316fa-7f14-4220-a510-4b944c6c4ab1", null, false, null, null, false, null, "kwilliams", null, null, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"), null, null, false, "00da1708-2a13-4adf-a0dc-1c013378006b", false, new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), null },
                    { "bd5731ae-aff2-4164-8834-5c77e7e72ba9", 0, "ff50f713-244b-4314-95fe-297fa97e6b92", null, false, null, null, false, null, "ka393939", null, null, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"), null, null, false, "cd2305e8-4288-4387-a662-71bf7a2c60c7", false, new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), null },
                    { "1772724e-94fc-4bb1-8d3a-568f6bf05be4", 0, "445581ef-b657-44b3-a96c-866cfb3d518c", null, false, null, null, false, null, "kaw3939", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce5"), null, null, false, "b4d9874b-d4c9-4fca-a87f-13aac6e4a1fe", false, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), null },
                    { "f6f44ed3-9cb3-40b2-9c7c-c941cbdf04c2", 0, "b6d59201-7318-4f20-88d1-4f3dead64745", null, false, null, null, false, null, "megan12", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce5"), null, null, false, "9f994605-d889-4078-a95f-aa5c2557b43a", false, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479812"), null }
                });
        }
    }
}
