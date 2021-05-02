using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11ba1a53-fcf1-4ac0-945d-05f3b4c0ad81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ce2d910-0641-42a2-9f37-8bba0a90f17c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82938624-240b-4f85-8869-abfc8f183b98");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3302f5f-bd25-494e-86f5-82e79028c050");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "OrganizationId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[,]
                {
                    { "a3302f5f-bd25-494e-86f5-82e79028c050", 0, "f8877616-3fd4-4090-aaa8-16147456ce69", null, false, null, null, false, null, "kwilliams", null, null, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"), null, null, false, "d45769cf-ed78-42a9-96f4-0e0256df1699", false, new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), null },
                    { "82938624-240b-4f85-8869-abfc8f183b98", 0, "0caa1ed4-cdc2-4b39-85a0-a689f932d8b0", null, false, null, null, false, null, "ka393939", null, null, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"), null, null, false, "8808a0f3-741a-40a2-a8d0-c6aea4dd2eb6", false, new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), null },
                    { "11ba1a53-fcf1-4ac0-945d-05f3b4c0ad81", 0, "3ae723b3-e033-4a8e-b54e-148dd6a5a1bd", null, false, null, null, false, null, "kaw3939", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce5"), null, null, false, "adc28533-8051-4758-a3a4-62b9520eb731", false, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), null },
                    { "2ce2d910-0641-42a2-9f37-8bba0a90f17c", 0, "1efaa060-5dab-4a4e-b444-f0c78ec8a733", null, false, null, null, false, null, "megan12", null, null, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce5"), null, null, false, "18f7585a-a3cf-4477-b786-33bcb9b39ac7", false, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479812"), null }
                });
        }
    }
}
