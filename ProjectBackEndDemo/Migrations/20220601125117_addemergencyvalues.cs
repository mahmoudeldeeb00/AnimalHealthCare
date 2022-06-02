using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEndDemo.Migrations
{
    public partial class addemergencyvalues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EndGlucozEmergency",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EndPulseEmergency",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EndTempretureEmergency",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartGlucozEmergency",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartPulseEmergency",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartTempretureEmergency",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndGlucozEmergency",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "EndPulseEmergency",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "EndTempretureEmergency",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "StartGlucozEmergency",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "StartPulseEmergency",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "StartTempretureEmergency",
                table: "Animals");
        }
    }
}
