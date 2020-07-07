using Microsoft.EntityFrameworkCore.Migrations;

namespace EDAPI.Migrations
{
    public partial class Devices_SampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "DeviceName", "Make" },
                values: new object[] { 1, "IPhone", "Apple" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "DeviceName", "Make" },
                values: new object[] { 2, "Apple Watch", "Apple" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "DeviceName", "Make" },
                values: new object[] { 3, "Macbook", "Apple" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
