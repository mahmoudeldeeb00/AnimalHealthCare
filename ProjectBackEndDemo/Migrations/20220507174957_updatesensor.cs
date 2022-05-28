using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEndDemo.Migrations
{
    public partial class updatesensor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "SensorDatas",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateTable(
                name: "SensorMeters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorMeters", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SensorDatas_Type",
                table: "SensorDatas",
                column: "Type");

            migrationBuilder.AddForeignKey(
                name: "FK_SensorDatas_SensorMeters_Type",
                table: "SensorDatas",
                column: "Type",
                principalTable: "SensorMeters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SensorDatas_SensorMeters_Type",
                table: "SensorDatas");

            migrationBuilder.DropTable(
                name: "SensorMeters");

            migrationBuilder.DropIndex(
                name: "IX_SensorDatas_Type",
                table: "SensorDatas");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "SensorDatas");

            migrationBuilder.DropColumn(
                name: "AnimalGlucose",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AnimalTempreture",
                table: "AspNetUsers");
        }
    }
}
