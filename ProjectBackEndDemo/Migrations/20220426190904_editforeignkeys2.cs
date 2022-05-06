using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEndDemo.Migrations
{
    public partial class editforeignkeys2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiseaseSymptom");

            migrationBuilder.CreateTable(
                name: "DiseaseSymptoms",
                columns: table => new
                {
                    DiseaseId = table.Column<int>(type: "int", nullable: false),
                    symptomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseSymptoms", x => new { x.symptomId, x.DiseaseId });
                    table.ForeignKey(
                        name: "FK_DiseaseSymptoms_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseSymptoms_Symptoms_symptomId",
                        column: x => x.symptomId,
                        principalTable: "Symptoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseSymptoms_DiseaseId",
                table: "DiseaseSymptoms",
                column: "DiseaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiseaseSymptoms");

            migrationBuilder.CreateTable(
                name: "DiseaseSymptom",
                columns: table => new
                {
                    DiseaseId = table.Column<int>(type: "int", nullable: false),
                    SymptomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseSymptom", x => new { x.DiseaseId, x.SymptomId });
                    table.ForeignKey(
                        name: "FK_DiseaseSymptom_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseSymptom_Symptoms_SymptomId",
                        column: x => x.SymptomId,
                        principalTable: "Symptoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseSymptom_SymptomId",
                table: "DiseaseSymptom",
                column: "SymptomId");
        }
    }
}
