using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace attendance.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WorkingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClonkingIn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClockingOut = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BreakeTime = table.Column<decimal>(type: "TEXT", nullable: false),
                    WorkingTime = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendance");
        }
    }
}
