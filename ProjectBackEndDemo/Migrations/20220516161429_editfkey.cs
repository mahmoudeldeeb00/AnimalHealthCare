using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEndDemo.Migrations
{
    public partial class editfkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAnimals",
                table: "UserAnimals");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserAnimals");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "UserAnimals",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAnimals",
                table: "UserAnimals",
                columns: new[] { "ApplicationUserId", "AnimalId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAnimals",
                table: "UserAnimals");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "UserAnimals");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserAnimals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAnimals",
                table: "UserAnimals",
                columns: new[] { "UserId", "AnimalId" });
        }
    }
}
