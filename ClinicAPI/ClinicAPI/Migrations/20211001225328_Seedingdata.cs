using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicAPI.Migrations
{
    public partial class Seedingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Floor", "Name" },
                values: new object[] { 1, 1, "Gynecology office" });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Floor", "Name" },
                values: new object[] { 2, 1, "Surgeon office" });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Floor", "Name" },
                values: new object[] { 3, 1, "Psychiatry office" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "OfficeId", "Speciality", "Surname" },
                values: new object[] { 1, "Adelaida", 1, "Gynecology", "Timko" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "OfficeId", "Speciality", "Surname" },
                values: new object[] { 2, "Zehang", 2, "Surgery", "Wang" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "OfficeId", "Speciality", "Surname" },
                values: new object[] { 3, "Sasha", 3, "Psychology", "Steklovata" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
