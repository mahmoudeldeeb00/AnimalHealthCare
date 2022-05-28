using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEndDemo.Migrations
{
    public partial class eeditsomefutures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Animals_AnimalId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAnimals_AspNetUsers_AppUserId",
                table: "UserAnimals");

            migrationBuilder.DropIndex(
                name: "IX_UserAnimals_AppUserId",
                table: "UserAnimals");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "UserAnimals");

            migrationBuilder.DropColumn(
                name: "AnimalGlucose",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AnimalTempreture",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimals_ApplicationUserId",
                table: "UserAnimals",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Animals_AnimalId",
                table: "AspNetUsers",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnimals_AspNetUsers_ApplicationUserId",
                table: "UserAnimals",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Animals_AnimalId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAnimals_AspNetUsers_ApplicationUserId",
                table: "UserAnimals");

            migrationBuilder.DropIndex(
                name: "IX_UserAnimals_ApplicationUserId",
                table: "UserAnimals");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "UserAnimals",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnimalGlucose",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AnimalTempreture",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimals_AppUserId",
                table: "UserAnimals",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Animals_AnimalId",
                table: "AspNetUsers",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnimals_AspNetUsers_AppUserId",
                table: "UserAnimals",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
