using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HW1API.Migrations
{
    /// <inheritdoc />
    public partial class AddedLessonSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LessonChart",
                columns: new[] { "LessonId", "LessonSubject" },
                values: new object[,]
                {
                    { 1, "API Construction" },
                    { 2, "Security Developement" },
                    { 3, "Decision Tables" },
                    { 4, "Free Space" },
                    { 5, "Dont Steal My Nachos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LessonChart",
                keyColumn: "LessonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LessonChart",
                keyColumn: "LessonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LessonChart",
                keyColumn: "LessonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LessonChart",
                keyColumn: "LessonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LessonChart",
                keyColumn: "LessonId",
                keyValue: 5);
        }
    }
}
