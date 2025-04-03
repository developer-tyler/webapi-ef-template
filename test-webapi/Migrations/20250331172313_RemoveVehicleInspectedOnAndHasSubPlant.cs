using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test_webapi.Migrations
{
    /// <inheritdoc />
    public partial class RemoveVehicleInspectedOnAndHasSubPlant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasSubPlant",
                table: "Inspections");

            migrationBuilder.DropColumn(
                name: "VehicleInspectedOn",
                table: "Inspections");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasSubPlant",
                table: "Inspections",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehicleInspectedOn",
                table: "Inspections",
                type: "int",
                nullable: true);
        }
    }
}
