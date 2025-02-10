using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class FixRoleConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27727359-58a7-4c46-9a8d-74e17e0d6071");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d551d322-ee36-4eb4-8d59-22add857ae47");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e40b55f8-0b34-4ebf-b5f7-cf93dd4f1d6a", null, "Administrator", "ADMINISTRATOR" },
                    { "f78c2bb9-5dfc-4cb3-9b8f-95cb0a2a491a", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e40b55f8-0b34-4ebf-b5f7-cf93dd4f1d6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f78c2bb9-5dfc-4cb3-9b8f-95cb0a2a491a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27727359-58a7-4c46-9a8d-74e17e0d6071", null, "Administrator", "ADMINISTRATOR" },
                    { "d551d322-ee36-4eb4-8d59-22add857ae47", null, "User", "USER" }
                });
        }
    }
}
