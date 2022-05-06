using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEndDemo.Migrations
{
    public partial class addvirtualproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AnimalId",
                table: "AspNetUsers");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AnimalId",
                table: "AspNetUsers",
                column: "AnimalId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AnimalId",
                table: "AspNetUsers");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AnimalId",
                table: "AspNetUsers",
                column: "AnimalId");
        }
    }
}
