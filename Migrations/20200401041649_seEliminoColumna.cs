using Microsoft.EntityFrameworkCore.Migrations;

namespace covidtrackerhnApi.Migrations
{
    public partial class seEliminoColumna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Edad",
                table: "CovidCases");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Edad",
                table: "CovidCases",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
