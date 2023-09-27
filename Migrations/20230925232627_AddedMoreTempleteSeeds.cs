using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HW1API.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreTempleteSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Table Example",
                keyColumn: "TempleteID",
                keyValue: 1,
                column: "TrueValue",
                value: 11.34f);

            migrationBuilder.InsertData(
                table: "Table Example",
                columns: new[] { "TempleteID", "Name", "TrueValue" },
                values: new object[,]
                {
                    { 2, "Template B", 27.63f },
                    { 3, "Mega Template", 19.87f },
                    { 4, "Newborn Template", 3.21f },
                    { 5, "Template Regret", 88.88f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Table Example",
                keyColumn: "TempleteID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Table Example",
                keyColumn: "TempleteID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Table Example",
                keyColumn: "TempleteID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Table Example",
                keyColumn: "TempleteID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Table Example",
                keyColumn: "TempleteID",
                keyValue: 1,
                column: "TrueValue",
                value: 1.34f);
        }
    }
}
