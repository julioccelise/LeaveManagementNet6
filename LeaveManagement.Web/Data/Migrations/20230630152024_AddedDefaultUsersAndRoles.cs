using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2adf4db5-aba3-4c4c-30ba-22a40db57b54", null, "User", "USER" },
                    { "434f5db4-aba3-4c4c-30ba-95a40fb57a63", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0182ece0-bb23-4dbe-900e-8d6f0b005729", 0, "d6de725f-225b-44d8-b72f-eaf0e9d0af12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "System", "Admin", false, null, "ADMIN@TEST.COM", null, "AQAAAAIAAYagAAAAEEkjmP13ppWpEk0lQS5CJfcqszHuju8DxyGS4qUQPo0tvYEsHtxHmH7G3conmUNpaQ==", null, false, "aabf16ba-067a-44d0-a3a5-309fba33e75d", null, false, null },
                    { "102f5db4-aba3-4c4c-80ca-95a40fb57a62", 0, "0b571ae3-dccc-4535-84dc-3a8e6ec290c8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jcelis@itx.com", false, "Julio", "Celis", false, null, "JCELIS@ITX.COM", null, "AQAAAAIAAYagAAAAEMAkRy55soIVVfHFy5XjPTCWr0nnzE1t7pmieK+/z7OodUjqslJRGd+hpkVw7/uB0Q==", null, false, "696da0c3-2d6b-4ab2-8842-356304296c49", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "434f5db4-aba3-4c4c-30ba-95a40fb57a63", "0182ece0-bb23-4dbe-900e-8d6f0b005729" },
                    { "2adf4db5-aba3-4c4c-30ba-22a40db57b54", "102f5db4-aba3-4c4c-80ca-95a40fb57a62" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "434f5db4-aba3-4c4c-30ba-95a40fb57a63", "0182ece0-bb23-4dbe-900e-8d6f0b005729" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2adf4db5-aba3-4c4c-30ba-22a40db57b54", "102f5db4-aba3-4c4c-80ca-95a40fb57a62" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2adf4db5-aba3-4c4c-30ba-22a40db57b54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "434f5db4-aba3-4c4c-30ba-95a40fb57a63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0182ece0-bb23-4dbe-900e-8d6f0b005729");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102f5db4-aba3-4c4c-80ca-95a40fb57a62");
        }
    }
}
