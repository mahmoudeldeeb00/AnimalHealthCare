﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEndDemo.Migrations
{
    public partial class handlemedicinedieaseforeigns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiseaseMedicines",
                columns: table => new
                {
                    DiseaseId = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseMedicines", x => new { x.DiseaseId, x.MedicineId });
                    table.ForeignKey(
                        name: "FK_DiseaseMedicines_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseaseMedicines_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiseaseMedicines_MedicineId",
                table: "DiseaseMedicines",
                column: "MedicineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiseaseMedicines");
        }
    }
}
