using Microsoft.EntityFrameworkCore.Migrations;

namespace EDAPI.Migrations
{
    public partial class Devices_Add_Make : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Make",
                table: "Devices",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Make",
                table: "Devices");
        }
    }
}
