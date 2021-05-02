using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c90cac24-56a0-40cf-aa14-13292b655ed0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd3c815d-5358-484d-b49d-6842d78dd67a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f996588-52ff-4e3d-8709-146c8ff84aa2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88523f5b-99e3-4e5d-831c-4641e1bd7f5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e88a7a98-39cc-47c0-97a8-487e0ea71ce0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea602c4d-57df-442a-8cf9-3e55947f2d0d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4afc93f9-fdf9-412a-9b61-4752c1ccb1ae", "a0d078ce-7ad0-4f78-9056-46bcf59f0e60", "manager", "MANAGER" },
                    { "b4185aff-9452-412c-9670-6c8de5e43f0b", "34c83356-5269-430f-b89a-5459a6544951", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OrganizationId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[,]
                {
                    { "3dc25d54-a9b0-4866-9e6b-d15804261e3f", 0, "91062aad-df3d-4204-b5b3-0408f16a19e0", null, false, null, null, false, null, "kwilliams", null, null, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"), null, null, false, "eb0edd9a-7368-4c9c-8d5c-c3976f540cd8", false, new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), null },
                    { "18c2c699-fbd8-41fb-932b-6ad61d595b90", 0, "a772da86-a328-47ae-b679-4ab7af253299", null, false, null, null, false, null, "ka393939", null, null, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"), null, null, false, "8f60a659-7225-45e0-a50c-b45e7ed3e71a", false, new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), null },
                    { "2a2a212b-f8ef-4c4c-bcdd-cf325f7c7113", 0, "e408b1a8-d1f2-4344-a3ed-689327a82c76", null, false, null, null, false, null, "kaw3939", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce5"), null, null, false, "27b489ab-3f9a-4841-bf03-bc286c4e021c", false, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), null },
                    { "82a83c31-63d2-49e5-a89d-25b00c31da7e", 0, "ad77af37-a3f4-46c4-93f4-f625330f34eb", null, false, null, null, false, null, "megan12", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce5"), null, null, false, "28935fec-a899-4cc4-85f9-7f404ca21563", false, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479812"), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4afc93f9-fdf9-412a-9b61-4752c1ccb1ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4185aff-9452-412c-9670-6c8de5e43f0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18c2c699-fbd8-41fb-932b-6ad61d595b90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a2a212b-f8ef-4c4c-bcdd-cf325f7c7113");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dc25d54-a9b0-4866-9e6b-d15804261e3f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82a83c31-63d2-49e5-a89d-25b00c31da7e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fd3c815d-5358-484d-b49d-6842d78dd67a", "678902d6-76c0-48f2-af08-605828309caf", "manager", "MANAGER" },
                    { "c90cac24-56a0-40cf-aa14-13292b655ed0", "621b914f-b412-4576-98fb-8cb8916055d6", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OrganizationId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[,]
                {
                    { "e88a7a98-39cc-47c0-97a8-487e0ea71ce0", 0, "c4ce8d7a-2784-4e67-932a-28225682d600", null, false, null, null, false, null, "kwilliams", null, null, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"), null, null, false, "281701dd-7825-402b-96f9-f898b1d39426", false, new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), null },
                    { "ea602c4d-57df-442a-8cf9-3e55947f2d0d", 0, "7d0e07ef-edd0-49bf-ba6b-1b470f116154", null, false, null, null, false, null, "ka393939", null, null, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"), null, null, false, "255e0171-f444-4994-a7c0-387454566d84", false, new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), null },
                    { "1f996588-52ff-4e3d-8709-146c8ff84aa2", 0, "0350bfd0-eca5-4b57-ae69-497482765b00", null, false, null, null, false, null, "kaw3939", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce5"), null, null, false, "e0214506-4eaf-4e21-8097-3fae340fd906", false, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), null },
                    { "88523f5b-99e3-4e5d-831c-4641e1bd7f5d", 0, "d6e0cbc1-9404-46e5-b918-f1c861511f89", null, false, null, null, false, null, "megan12", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce5"), null, null, false, "27ab7d15-8a42-4ea0-af56-c83326198646", false, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479812"), null }
                });
        }
    }
}
