using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEndDemo.Migrations
{
    public partial class editforeignkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalDisease");

            migrationBuilder.DropTable(
                name: "DiseaseMedicine");

            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "Diseases",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Diseases_AnimalId",
                table: "Diseases",
                column: "AnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diseases_Animals_AnimalId",
                table: "Diseases",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diseases_Animals_AnimalId",
                table: "Diseases");

            migrationBuilder.DropIndex(
                name: "IX_Diseases_AnimalId",
                table: "Diseases");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Diseases");

            migrationBuilder.CreateTable(
                name: "AnimalDisease",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false),
                    DiseaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalDisease", x => new { x.AnimalId, x.DiseaseId });
                    table.ForeignKey(
                        name: "FK_AnimalDisease_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalDisease_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseMedicine",
                columns: table => new
                {
                    DiseaseId = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseMedicine", x => new { x.DiseaseId, x.MedicineId });
                    table.ForeignKey(
                        name: "FK_DiseaseMedicine_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseMedicine_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalDisease_DiseaseId",
                table: "AnimalDisease",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseMedicine_MedicineId",
                table: "DiseaseMedicine",
                column: "MedicineId");
        }
    }
}
