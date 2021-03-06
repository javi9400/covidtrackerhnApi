﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace covidtrackerhnApi.Migrations
{
    public partial class seAgregoColumnaEdad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Edad",
                table: "CovidCases",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Edad",
                table: "CovidCases");
        }
    }
}
