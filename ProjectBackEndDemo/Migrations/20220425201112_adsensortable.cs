using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEndDemo.Migrations
{
    public partial class adsensortable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SensorDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowToDeal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmergency = table.Column<bool>(type: "bit", nullable: false),
                    AnimalId = table.Column<int>(type: "int", nullable: false),
                    DiseaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SensorDatas_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SensorDatas_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SensorDatas_AnimalId",
                table: "SensorDatas",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_SensorDatas_DiseaseId",
                table: "SensorDatas",
                column: "DiseaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SensorDatas");
        }
    }
}
