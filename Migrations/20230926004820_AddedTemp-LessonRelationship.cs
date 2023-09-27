using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW1API.Migrations
{
    /// <inheritdoc />
    public partial class AddedTempLessonRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LessonTemplate",
                columns: table => new
                {
                    LessonsLessonId = table.Column<int>(type: "INTEGER", nullable: false),
                    TemplatesTempleteID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonTemplate", x => new { x.LessonsLessonId, x.TemplatesTempleteID });
                    table.ForeignKey(
                        name: "FK_LessonTemplate_LessonChart_LessonsLessonId",
                        column: x => x.LessonsLessonId,
                        principalTable: "LessonChart",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonTemplate_Table Example_TemplatesTempleteID",
                        column: x => x.TemplatesTempleteID,
                        principalTable: "Table Example",
                        principalColumn: "TempleteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LessonTemplate_TemplatesTempleteID",
                table: "LessonTemplate",
                column: "TemplatesTempleteID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonTemplate");
        }
    }
}
