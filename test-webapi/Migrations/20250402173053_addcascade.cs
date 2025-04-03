using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test_webapi.Migrations
{
    /// <inheritdoc />
    public partial class addcascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AllPlant_PlantCategories_PlantCategory",
                table: "AllPlant");

            migrationBuilder.DropForeignKey(
                name: "FK_Inspections_PlantHoldings_HoldingID",
                table: "Inspections");

            migrationBuilder.DropForeignKey(
                name: "FK_PlantHoldings_AllPlant_PlantNameID",
                table: "PlantHoldings");

            migrationBuilder.DropForeignKey(
                name: "FK_PlantHoldings_Customers_CustID",
                table: "PlantHoldings");

            migrationBuilder.AddForeignKey(
                name: "FK_AllPlant_PlantCategories_PlantCategory",
                table: "AllPlant",
                column: "PlantCategory",
                principalTable: "PlantCategories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inspections_PlantHoldings_HoldingID",
                table: "Inspections",
                column: "HoldingID",
                principalTable: "PlantHoldings",
                principalColumn: "HoldingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlantHoldings_AllPlant_PlantNameID",
                table: "PlantHoldings",
                column: "PlantNameID",
                principalTable: "AllPlant",
                principalColumn: "PlantNameID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlantHoldings_Customers_CustID",
                table: "PlantHoldings",
                column: "CustID",
                principalTable: "Customers",
                principalColumn: "CustID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AllPlant_PlantCategories_PlantCategory",
                table: "AllPlant");

            migrationBuilder.DropForeignKey(
                name: "FK_Inspections_PlantHoldings_HoldingID",
                table: "Inspections");

            migrationBuilder.DropForeignKey(
                name: "FK_PlantHoldings_AllPlant_PlantNameID",
                table: "PlantHoldings");

            migrationBuilder.DropForeignKey(
                name: "FK_PlantHoldings_Customers_CustID",
                table: "PlantHoldings");

            migrationBuilder.AddForeignKey(
                name: "FK_AllPlant_PlantCategories_PlantCategory",
                table: "AllPlant",
                column: "PlantCategory",
                principalTable: "PlantCategories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inspections_PlantHoldings_HoldingID",
                table: "Inspections",
                column: "HoldingID",
                principalTable: "PlantHoldings",
                principalColumn: "HoldingID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlantHoldings_AllPlant_PlantNameID",
                table: "PlantHoldings",
                column: "PlantNameID",
                principalTable: "AllPlant",
                principalColumn: "PlantNameID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlantHoldings_Customers_CustID",
                table: "PlantHoldings",
                column: "CustID",
                principalTable: "Customers",
                principalColumn: "CustID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
