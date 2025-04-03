using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test_webapi.Migrations
{
    /// <inheritdoc />
    public partial class testcascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlantHoldings_Status_StatusID",
                table: "PlantHoldings");

            migrationBuilder.AddForeignKey(
                name: "FK_PlantHoldings_Status_StatusID",
                table: "PlantHoldings",
                column: "StatusID",
                principalTable: "Status",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlantHoldings_Status_StatusID",
                table: "PlantHoldings");

            migrationBuilder.AddForeignKey(
                name: "FK_PlantHoldings_Status_StatusID",
                table: "PlantHoldings",
                column: "StatusID",
                principalTable: "Status",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
