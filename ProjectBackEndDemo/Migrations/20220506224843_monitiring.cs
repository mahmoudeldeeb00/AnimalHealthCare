using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEndDemo.Migrations
{
    public partial class monitiring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LastSensorSend",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SensorDatas_LastSensorSend",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LastSensorSend",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastSensorSend",
                table: "AspNetUsers");
        }
    }
}
