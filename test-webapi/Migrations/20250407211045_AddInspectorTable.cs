using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test_webapi.Migrations
{
    /// <inheritdoc />
    public partial class AddInspectorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InspectorID",
                table: "Inspections",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Inspectors",
                columns: table => new
                {
                    InspectorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InspectorsName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspectors", x => x.InspectorID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_InspectorID",
                table: "Inspections",
                column: "InspectorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspections_Inspectors_InspectorID",
                table: "Inspections",
                column: "InspectorID",
                principalTable: "Inspectors",
                principalColumn: "InspectorID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspections_Inspectors_InspectorID",
                table: "Inspections");

            migrationBuilder.DropTable(
                name: "Inspectors");

            migrationBuilder.DropIndex(
                name: "IX_Inspections_InspectorID",
                table: "Inspections");

            migrationBuilder.DropColumn(
                name: "InspectorID",
                table: "Inspections");
        }
    }
}
