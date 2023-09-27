using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW1API.Migrations
{
    /// <inheritdoc />
    public partial class AddedConnectionsandReview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Connection",
                columns: table => new
                {
                    ConnectionID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ConnectionDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connection", x => x.ConnectionID);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ConnectionID = table.Column<int>(type: "INTEGER", nullable: false),
                    ReviewNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    TempleteID = table.Column<int>(type: "INTEGER", nullable: false),
                    AForthThing = table.Column<int>(type: "INTEGER", nullable: false),
                    ReviewTime = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Reviews_Connection_ConnectionID",
                        column: x => x.ConnectionID,
                        principalTable: "Connection",
                        principalColumn: "ConnectionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ConnectionID",
                table: "Reviews",
                column: "ConnectionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Connection");
        }
    }
}
