using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEndDemo.Migrations
{
    public partial class adduseranimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SensorDatas_LastSensorSend",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LastSensorSend",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "EndGlucose",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EndPulse",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EndTempreture",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartGlucose",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartPulse",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartTempreture",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAnimals",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AnimalId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderType = table.Column<int>(type: "int", nullable: false),
                    pictureSrc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastSensorTempretureSend = table.Column<int>(type: "int", nullable: false),
                    LastSensorGlucoseSend = table.Column<int>(type: "int", nullable: false),
                    LastSensorPulseSend = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnimals", x => new { x.UserId, x.AnimalId });
                    table.ForeignKey(
                        name: "FK_UserAnimals_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAnimals_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAnimals_Genders_GenderType",
                        column: x => x.GenderType,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimals_AnimalId",
                table: "UserAnimals",
                column: "AnimalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimals_AppUserId",
                table: "UserAnimals",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimals_GenderType",
                table: "UserAnimals",
                column: "GenderType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAnimals");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropColumn(
                name: "EndGlucose",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "EndPulse",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "EndTempreture",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "StartGlucose",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "StartPulse",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "StartTempreture",
                table: "Animals");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LastSensorSend",
                table: "AspNetUsers",
                column: "LastSensorSend");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SensorDatas_LastSensorSend",
                table: "AspNetUsers",
                column: "LastSensorSend",
                principalTable: "SensorDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
