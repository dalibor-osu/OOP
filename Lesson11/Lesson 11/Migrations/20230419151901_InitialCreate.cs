using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lesson_11.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hodnocenis",
                columns: table => new
                {
                    HodnoceniId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdStudenta = table.Column<int>(type: "int", nullable: false),
                    ZkratkaPredmetu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumHodnoceni = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    HodnoceniStudenta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hodnocenis", x => x.HodnoceniId);
                });

            migrationBuilder.CreateTable(
                name: "Predmets",
                columns: table => new
                {
                    PredmetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Zkratka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predmets", x => x.PredmetId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdStudenta = table.Column<int>(type: "int", nullable: false),
                    Jmeno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prijmeni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumNarozeni = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "ZapsanePredmets",
                columns: table => new
                {
                    ZapsanePredmetyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdStudenta = table.Column<int>(type: "int", nullable: false),
                    ZkratkaPredmetu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZapsanePredmets", x => x.ZapsanePredmetyId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hodnocenis");

            migrationBuilder.DropTable(
                name: "Predmets");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "ZapsanePredmets");
        }
    }
}
