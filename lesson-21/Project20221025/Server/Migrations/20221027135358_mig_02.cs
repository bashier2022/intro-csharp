using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project20221025.Server.Migrations
{
    public partial class mig_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Measurements_MeasurementTypeId",
                table: "Measurements",
                column: "MeasurementTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Measurements_MeasurementTypes_MeasurementTypeId",
                table: "Measurements",
                column: "MeasurementTypeId",
                principalTable: "MeasurementTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Measurements_MeasurementTypes_MeasurementTypeId",
                table: "Measurements");

            migrationBuilder.DropIndex(
                name: "IX_Measurements_MeasurementTypeId",
                table: "Measurements");
        }
    }
}
