using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEndDemo.Migrations
{
    public partial class makerelationonetomany2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 3);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AnimalId",
                table: "AspNetUsers",
                column: "AnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Animals_AnimalId",
                table: "AspNetUsers",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Animals_AnimalId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AnimalId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "AspNetUsers");
        }
    }
}
