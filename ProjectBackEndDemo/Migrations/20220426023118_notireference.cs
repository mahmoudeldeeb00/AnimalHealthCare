using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEndDemo.Migrations
{
    public partial class notireference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlReference",
                table: "UserNotifications");

            migrationBuilder.AddColumn<string>(
                name: "UrlReference",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlReference",
                table: "Notifications");

            migrationBuilder.AddColumn<string>(
                name: "UrlReference",
                table: "UserNotifications",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
