using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace IceReportsAPI.Migrations
{
    public partial class MakeAreaSingular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Areas_Reports_ReportId",
                table: "Areas");

            migrationBuilder.DropIndex(
                name: "IX_Areas_ReportId",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "Areas");

            migrationBuilder.AddColumn<int>(
                name: "AreaId",
                table: "Reports",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_AreaId",
                table: "Reports",
                column: "AreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Areas_AreaId",
                table: "Reports",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "AreaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Areas_AreaId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_AreaId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "AreaId",
                table: "Reports");

            migrationBuilder.AddColumn<int>(
                name: "ReportId",
                table: "Areas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Areas_ReportId",
                table: "Areas",
                column: "ReportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Areas_Reports_ReportId",
                table: "Areas",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "ReportId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
