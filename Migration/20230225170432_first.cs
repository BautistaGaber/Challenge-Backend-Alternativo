using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChallengeAlternativo.primera
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Denomination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Habitants = table.Column<int>(type: "int", nullable: false),
                    TotalArea = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeographicIcons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Denomination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    height = table.Column<int>(type: "int", nullable: false),
                    History = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeographicIcons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeographicIcons_countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "continents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Denomination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeographicIconsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_continents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_continents_GeographicIcons_GeographicIconsId",
                        column: x => x.GeographicIconsId,
                        principalTable: "GeographicIcons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContinentCountry",
                columns: table => new
                {
                    ContinentId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContinentCountry", x => new { x.ContinentId, x.CountryId });
                    table.ForeignKey(
                        name: "FK_ContinentCountry_continents_ContinentId",
                        column: x => x.ContinentId,
                        principalTable: "continents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContinentCountry_countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContinentCountry_CountryId",
                table: "ContinentCountry",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_continents_GeographicIconsId",
                table: "continents",
                column: "GeographicIconsId");

            migrationBuilder.CreateIndex(
                name: "IX_GeographicIcons_CountryId",
                table: "GeographicIcons",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContinentCountry");

            migrationBuilder.DropTable(
                name: "continents");

            migrationBuilder.DropTable(
                name: "GeographicIcons");

            migrationBuilder.DropTable(
                name: "countries");
        }
    }
}
