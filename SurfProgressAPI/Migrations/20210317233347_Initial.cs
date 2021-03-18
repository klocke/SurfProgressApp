using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SurfProgressAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Surfboards",
                columns: table => new
                {
                    SurfboardId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DisplayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Length = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Width = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Thickness = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Volume = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    FinSetup = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Tail = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Shaper = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surfboards", x => x.SurfboardId);
                });

            migrationBuilder.CreateTable(
                name: "SurfSessions",
                columns: table => new
                {
                    SurfSessionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    TimeOfDay = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    WaveHeight = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    WaveDirection = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    WindDirection = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    WindSpeed = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    WaveCount = table.Column<int>(type: "int", nullable: false),
                    SurfboardId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurfSessions", x => x.SurfSessionId);
                    table.ForeignKey(
                        name: "FK_SurfSessions_Surfboards_SurfboardId",
                        column: x => x.SurfboardId,
                        principalTable: "Surfboards",
                        principalColumn: "SurfboardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SurfSessions_SurfboardId",
                table: "SurfSessions",
                column: "SurfboardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurfSessions");

            migrationBuilder.DropTable(
                name: "Surfboards");
        }
    }
}
