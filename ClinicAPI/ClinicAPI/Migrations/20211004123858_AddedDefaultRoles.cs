using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicAPI.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9947a872-f505-4d67-9816-a6b52ee6e156", "92263bff-cf33-43d4-a44b-510d60949916", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9cf71395-b7eb-46e3-bbbd-fddded845b56", "e0fbe38c-3505-4ed2-a41e-78b6386ceb71", "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "13aaa0b6-1f41-42d4-a424-f3edac0ec9a2", "65c58d5e-6f16-4ca2-8603-1bc5ff92b543", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13aaa0b6-1f41-42d4-a424-f3edac0ec9a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9947a872-f505-4d67-9816-a6b52ee6e156");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cf71395-b7eb-46e3-bbbd-fddded845b56");
        }
    }
}
