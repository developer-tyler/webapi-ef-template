using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test_webapi.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMailshotColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mailshot",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_CustID",
                table: "Notes",
                column: "CustID");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Customers_CustID",
                table: "Notes",
                column: "CustID",
                principalTable: "Customers",
                principalColumn: "CustID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Customers_CustID",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_CustID",
                table: "Notes");

            migrationBuilder.AddColumn<bool>(
                name: "Mailshot",
                table: "Customers",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 1,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 2,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 3,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 4,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 5,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 6,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 7,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 8,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 9,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 10,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 11,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 12,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 13,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 14,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 15,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 16,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 17,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 18,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 19,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 20,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 21,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 22,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 23,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 24,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 25,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 26,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 27,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 28,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 29,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 30,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 31,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 32,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 33,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 34,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 35,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 36,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 37,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 38,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 39,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 40,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 41,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 42,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 43,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 44,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 45,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 46,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 47,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 48,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 49,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 50,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 51,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 52,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 53,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 54,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 55,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 56,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 57,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 58,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 59,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 60,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 61,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 62,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 63,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 64,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 65,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 66,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 67,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 68,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 69,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 70,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 71,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 72,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 73,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 74,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 75,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 76,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 77,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 78,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 79,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 80,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 81,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 82,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 83,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 84,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 85,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 86,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 87,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 88,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 89,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 90,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 91,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 92,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 93,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 94,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 95,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 96,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 97,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 98,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 99,
                column: "Mailshot",
                value: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustID",
                keyValue: 100,
                column: "Mailshot",
                value: true);
        }
    }
}
