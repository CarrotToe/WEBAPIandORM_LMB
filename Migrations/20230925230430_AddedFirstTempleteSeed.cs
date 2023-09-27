using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW1API.Migrations
{
    /// <inheritdoc />
    public partial class AddedFirstTempleteSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Table Example",
                columns: new[] { "TempleteID", "Name", "TrueValue" },
                values: new object[] { 1, "First Template", 1.34f });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Table Example",
                keyColumn: "TempleteID",
                keyValue: 1);
        }
    }
}
