using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW1API.Migrations
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AForthThing",
                table: "Reviews",
                newName: "AFifthThing");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AFifthThing",
                table: "Reviews",
                newName: "AForthThing");
        }
    }
}
