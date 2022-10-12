using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hunter.API.Migrations
{
    public partial class SeededDefaultUsersandRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "KnownAs",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d58b9f5-6791-4ad7-bd56-df2fd72a6eb2", "a85e332d-ed73-47a4-a4f0-4e0bc040b0e9", "Administrator", "ADMINISTRATOR" },
                    { "1d97e3bb-98d2-427a-86b6-e66ba2c693ba", "1cff9d9d-165d-47f8-88de-ac73ed0d0fe1", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "KnownAs", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b9554fd5-af94-4d11-bc4e-4ba1b7cd1377", 0, "5b4cd4cd-318e-4c85-ab84-a68ca4834d5b", null, false, "System", "Admin", "Administrator", false, null, null, "ADMIN", null, "AQAAAAEAACcQAAAAEI092X4goSERpBQZRK3vQ+h43un8n2CRpWbUI4mb+M7hXWCOcv2I9qi3AMlI03E2QA==", null, false, "16ecc303-8753-4356-b405-e3fe25f9be10", false, "Admin" },
                    { "dfc49bbb-fa45-414d-aa35-e737ffa56e9a", 0, "c19323ea-def4-4f2d-9112-2a87e5b16ced", null, false, "Patch", "Patch", "Duncan", false, null, null, "PATCH", null, "AQAAAAEAACcQAAAAEH4xzvltv7GhCVUKRmAGgcpuTpdW6vM+KWNWIgtqx0rh0DUsLcDjKqdk6ogVviUwpQ==", null, false, "3d7620da-269b-4063-9b7d-47eba2d6116e", false, "Patch" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0d58b9f5-6791-4ad7-bd56-df2fd72a6eb2", "b9554fd5-af94-4d11-bc4e-4ba1b7cd1377" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1d97e3bb-98d2-427a-86b6-e66ba2c693ba", "dfc49bbb-fa45-414d-aa35-e737ffa56e9a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0d58b9f5-6791-4ad7-bd56-df2fd72a6eb2", "b9554fd5-af94-4d11-bc4e-4ba1b7cd1377" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1d97e3bb-98d2-427a-86b6-e66ba2c693ba", "dfc49bbb-fa45-414d-aa35-e737ffa56e9a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d58b9f5-6791-4ad7-bd56-df2fd72a6eb2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d97e3bb-98d2-427a-86b6-e66ba2c693ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9554fd5-af94-4d11-bc4e-4ba1b7cd1377");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfc49bbb-fa45-414d-aa35-e737ffa56e9a");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KnownAs",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
