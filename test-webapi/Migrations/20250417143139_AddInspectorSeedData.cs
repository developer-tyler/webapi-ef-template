using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test_webapi.Migrations
{
    /// <inheritdoc />
    public partial class AddInspectorSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Inspectors",
                columns: new[] { "InspectorID", "InspectorsName" },
                values: new object[,]
                {
                    { 1, "Allen Lee" },
                    { 2, "Aidan Lee" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inspectors",
                keyColumn: "InspectorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inspectors",
                keyColumn: "InspectorID",
                keyValue: 2);
        }
    }
}
