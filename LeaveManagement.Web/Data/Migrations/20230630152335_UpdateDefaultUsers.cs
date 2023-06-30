using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDefaultUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0182ece0-bb23-4dbe-900e-8d6f0b005729",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "21eb7c3b-45e7-4c7b-9223-99874d0a2b50", true, "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAENtkq4e8VzG4mdlwF9v29ECBeZVzR4ts6PEbeHJYXybA3mYtqdpgiloFU2esF+lRaQ==", "7b7f71b7-b8e1-48ec-b467-aacc963eac6c", "admin@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102f5db4-aba3-4c4c-80ca-95a40fb57a62",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "50e1790e-87ed-491e-b87d-e4866ec8bf46", true, "JCELIS@ITX.COM", "AQAAAAIAAYagAAAAEKQNxN23TGM9r7jsIkPlIOsFSH+UwQDpR7+di4OLzNiBV8QfQ73b3SYfGlDC0C6Cvg==", "17b171e7-f285-44ec-a5b0-5ce44422d9c1", "jcelis@itx.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0182ece0-bb23-4dbe-900e-8d6f0b005729",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d6de725f-225b-44d8-b72f-eaf0e9d0af12", false, null, "AQAAAAIAAYagAAAAEEkjmP13ppWpEk0lQS5CJfcqszHuju8DxyGS4qUQPo0tvYEsHtxHmH7G3conmUNpaQ==", "aabf16ba-067a-44d0-a3a5-309fba33e75d", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102f5db4-aba3-4c4c-80ca-95a40fb57a62",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0b571ae3-dccc-4535-84dc-3a8e6ec290c8", false, null, "AQAAAAIAAYagAAAAEMAkRy55soIVVfHFy5XjPTCWr0nnzE1t7pmieK+/z7OodUjqslJRGd+hpkVw7/uB0Q==", "696da0c3-2d6b-4ab2-8842-356304296c49", null });
        }
    }
}
