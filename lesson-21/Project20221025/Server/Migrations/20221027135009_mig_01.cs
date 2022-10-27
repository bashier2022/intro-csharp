using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project20221025.Server.Migrations
{
    public partial class mig_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Modules_PlatformId",
                table: "Modules",
                column: "PlatformId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Platforms_PlatformId",
                table: "Modules",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Platforms_PlatformId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Modules_PlatformId",
                table: "Modules");
        }
    }
}
