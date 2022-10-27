﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project20221025.Server.Migrations
{
    public partial class mig_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Measurements_ModuleId",
                table: "Measurements",
                column: "ModuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Measurements_Modules_ModuleId",
                table: "Measurements",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Measurements_Modules_ModuleId",
                table: "Measurements");

            migrationBuilder.DropIndex(
                name: "IX_Measurements_ModuleId",
                table: "Measurements");
        }
    }
}
