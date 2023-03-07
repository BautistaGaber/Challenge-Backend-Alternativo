using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChallengeAlternativo.primera
{
    /// <inheritdoc />
    public partial class tercera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_continents_GeographicIcons_GeographicIconsId",
                table: "continents");

            migrationBuilder.DropForeignKey(
                name: "FK_GeographicIcons_countries_CountryId",
                table: "GeographicIcons");

            migrationBuilder.DropTable(
                name: "ContinentCountry");

            migrationBuilder.DropIndex(
                name: "IX_continents_GeographicIconsId",
                table: "continents");

            migrationBuilder.DropColumn(
                name: "GeographicIconsId",
                table: "continents");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "GeographicIcons",
                newName: "ContinentId");

            migrationBuilder.RenameIndex(
                name: "IX_GeographicIcons_CountryId",
                table: "GeographicIcons",
                newName: "IX_GeographicIcons_ContinentId");

            migrationBuilder.AddColumn<int>(
                name: "ContinentId",
                table: "countries",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CountryGeographicIcons",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    GeographicIconsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryGeographicIcons", x => new { x.CountryId, x.GeographicIconsId });
                    table.ForeignKey(
                        name: "FK_CountryGeographicIcons_GeographicIcons_GeographicIconsId",
                        column: x => x.GeographicIconsId,
                        principalTable: "GeographicIcons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryGeographicIcons_countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_countries_ContinentId",
                table: "countries",
                column: "ContinentId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryGeographicIcons_GeographicIconsId",
                table: "CountryGeographicIcons",
                column: "GeographicIconsId");

            migrationBuilder.AddForeignKey(
                name: "FK_countries_continents_ContinentId",
                table: "countries",
                column: "ContinentId",
                principalTable: "continents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GeographicIcons_continents_ContinentId",
                table: "GeographicIcons",
                column: "ContinentId",
                principalTable: "continents",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_countries_continents_ContinentId",
                table: "countries");

            migrationBuilder.DropForeignKey(
                name: "FK_GeographicIcons_continents_ContinentId",
                table: "GeographicIcons");

            migrationBuilder.DropTable(
                name: "CountryGeographicIcons");

            migrationBuilder.DropIndex(
                name: "IX_countries_ContinentId",
                table: "countries");

            migrationBuilder.DropColumn(
                name: "ContinentId",
                table: "countries");

            migrationBuilder.RenameColumn(
                name: "ContinentId",
                table: "GeographicIcons",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_GeographicIcons_ContinentId",
                table: "GeographicIcons",
                newName: "IX_GeographicIcons_CountryId");

            migrationBuilder.AddColumn<int>(
                name: "GeographicIconsId",
                table: "continents",
                type: "int",
                nullable: true);

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
                name: "IX_continents_GeographicIconsId",
                table: "continents",
                column: "GeographicIconsId");

            migrationBuilder.CreateIndex(
                name: "IX_ContinentCountry_CountryId",
                table: "ContinentCountry",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_continents_GeographicIcons_GeographicIconsId",
                table: "continents",
                column: "GeographicIconsId",
                principalTable: "GeographicIcons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GeographicIcons_countries_CountryId",
                table: "GeographicIcons",
                column: "CountryId",
                principalTable: "countries",
                principalColumn: "Id");
        }
    }
}
