using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEndDemo.Migrations
{
    public partial class adddataa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentPulse",
                table: "UserAnimals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentTempreture",
                table: "UserAnimals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Currentlucose",
                table: "UserAnimals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentPulse",
                table: "UserAnimals");

            migrationBuilder.DropColumn(
                name: "CurrentTempreture",
                table: "UserAnimals");

            migrationBuilder.DropColumn(
                name: "Currentlucose",
                table: "UserAnimals");
        }
    }
}
