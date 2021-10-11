using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5051c7-130b-4ff4-a4e8-59df06a3918e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "943e96e9-8ffb-4b10-abd3-61de03f58bf2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4d50f48-b96a-4e7a-853b-c7b39154e39a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "153ab403-902a-4deb-ad24-036360639e14", "e51917ba-3563-4a82-bbc2-4c9d6ca6c93e", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ade324e-2f57-4df6-a80a-2fc5e16317fe", "a8d0d4c3-dbf8-49a9-85cc-23db17b4239b", "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80b88993-1583-4fef-a530-6987d5b161d0", "5c2d8ec0-a26f-4c02-88d9-7674071086ab", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "153ab403-902a-4deb-ad24-036360639e14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ade324e-2f57-4df6-a80a-2fc5e16317fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80b88993-1583-4fef-a530-6987d5b161d0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c5051c7-130b-4ff4-a4e8-59df06a3918e", "1dd5df67-c999-4804-b3ef-e5b67446d1bf", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "943e96e9-8ffb-4b10-abd3-61de03f58bf2", "1b6b2896-ab63-4992-8241-d94b0d67ff06", "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4d50f48-b96a-4e7a-853b-c7b39154e39a", "084a16eb-22e1-4414-b7b2-85da3ab86a4f", "Administrator", "ADMINISTRATOR" });
        }
    }
}
