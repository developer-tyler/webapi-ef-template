using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test_webapi.Migrations
{
    /// <inheritdoc />
    public partial class AddNewSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlantCategories",
                columns: new[] { "CategoryID", "CategoryDescription" },
                values: new object[,]
                {
                    { 1, "Heavy Plant" },
                    { 2, "Small Plant" },
                    { 3, "Access Equipment" },
                    { 4, "Power Tools" },
                    { 5, "Safety Equipment" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusID", "StatusDescription" },
                values: new object[,]
                {
                    { 1, "Available" },
                    { 2, "In Use" },
                    { 3, "Under Maintenance" },
                    { 4, "Out of Service" },
                    { 5, "Reserved" }
                });

            migrationBuilder.InsertData(
                table: "AllPlant",
                columns: new[] { "PlantNameID", "NormalPrice", "PlantCategory", "PlantDescription" },
                values: new object[,]
                {
                    { 1, "150.00", 1, "Excavator 2T" },
                    { 2, "95.00", 3, "Scissor Lift" },
                    { 3, "45.00", 2, "Concrete Mixer" },
                    { 4, "25.00", 4, "Power Drill" },
                    { 5, "15.00", 5, "Safety Harness" }
                });

            migrationBuilder.InsertData(
                table: "PlantHoldings",
                columns: new[] { "HoldingID", "CustID", "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[,]
                {
                    { 1, 1, 1, "2000kg", "EXC001", 2 },
                    { 2, 2, 2, "300kg", "LIFT001", 1 },
                    { 3, 3, 3, "100kg", "MIX001", 3 },
                    { 4, 4, 4, "N/A", "DRILL001", 1 },
                    { 5, 5, 5, "150kg", "SAFE001", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PlantHoldings",
                keyColumn: "HoldingID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AllPlant",
                keyColumn: "PlantNameID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AllPlant",
                keyColumn: "PlantNameID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AllPlant",
                keyColumn: "PlantNameID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AllPlant",
                keyColumn: "PlantNameID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AllPlant",
                keyColumn: "PlantNameID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlantCategories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlantCategories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlantCategories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlantCategories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PlantCategories",
                keyColumn: "CategoryID",
                keyValue: 5);
        }
    }
}
