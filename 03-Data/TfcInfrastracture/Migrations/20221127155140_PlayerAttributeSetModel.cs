using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TfcInfrastracture.Migrations
{
    public partial class PlayerAttributeSetModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerAttributeSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    Acceleration = table.Column<byte>(type: "tinyint", nullable: false),
                    Adaptability = table.Column<byte>(type: "tinyint", nullable: false),
                    Aggression = table.Column<byte>(type: "tinyint", nullable: false),
                    Agility = table.Column<byte>(type: "tinyint", nullable: false),
                    Ambition = table.Column<byte>(type: "tinyint", nullable: false),
                    Anticipation = table.Column<byte>(type: "tinyint", nullable: false),
                    ArealReach = table.Column<byte>(type: "tinyint", nullable: false),
                    Balance = table.Column<byte>(type: "tinyint", nullable: false),
                    Bravery = table.Column<byte>(type: "tinyint", nullable: false),
                    CommandOfArea = table.Column<byte>(type: "tinyint", nullable: false),
                    Communication = table.Column<byte>(type: "tinyint", nullable: false),
                    Composure = table.Column<byte>(type: "tinyint", nullable: false),
                    Concentration = table.Column<byte>(type: "tinyint", nullable: false),
                    Consistency = table.Column<byte>(type: "tinyint", nullable: false),
                    Controversy = table.Column<byte>(type: "tinyint", nullable: false),
                    Corners = table.Column<byte>(type: "tinyint", nullable: false),
                    Crossing = table.Column<byte>(type: "tinyint", nullable: false),
                    Decisions = table.Column<byte>(type: "tinyint", nullable: false),
                    Determination = table.Column<byte>(type: "tinyint", nullable: false),
                    Dirtiness = table.Column<byte>(type: "tinyint", nullable: false),
                    Drybbling = table.Column<byte>(type: "tinyint", nullable: false),
                    Eccentricity = table.Column<byte>(type: "tinyint", nullable: false),
                    Finishing = table.Column<byte>(type: "tinyint", nullable: false),
                    FirstTouch = table.Column<byte>(type: "tinyint", nullable: false),
                    Flair = table.Column<byte>(type: "tinyint", nullable: false),
                    FreeKicks = table.Column<byte>(type: "tinyint", nullable: false),
                    Handling = table.Column<byte>(type: "tinyint", nullable: false),
                    Heading = table.Column<byte>(type: "tinyint", nullable: false),
                    ImportantMatches = table.Column<byte>(type: "tinyint", nullable: false),
                    InjuryProneness = table.Column<byte>(type: "tinyint", nullable: false),
                    JumpingReach = table.Column<byte>(type: "tinyint", nullable: false),
                    Kicking = table.Column<byte>(type: "tinyint", nullable: false),
                    Leadership = table.Column<byte>(type: "tinyint", nullable: false),
                    LongShots = table.Column<byte>(type: "tinyint", nullable: false),
                    LongThrows = table.Column<byte>(type: "tinyint", nullable: false),
                    Loyality = table.Column<byte>(type: "tinyint", nullable: false),
                    Marking = table.Column<byte>(type: "tinyint", nullable: false),
                    NaturalFitness = table.Column<byte>(type: "tinyint", nullable: false),
                    OffTheBall = table.Column<byte>(type: "tinyint", nullable: false),
                    OneOnOnes = table.Column<byte>(type: "tinyint", nullable: false),
                    Pace = table.Column<byte>(type: "tinyint", nullable: false),
                    Passing = table.Column<byte>(type: "tinyint", nullable: false),
                    PenalityTaking = table.Column<byte>(type: "tinyint", nullable: false),
                    Positioning = table.Column<byte>(type: "tinyint", nullable: false),
                    Pressure = table.Column<byte>(type: "tinyint", nullable: false),
                    Professionalism = table.Column<byte>(type: "tinyint", nullable: false),
                    Reflex = table.Column<byte>(type: "tinyint", nullable: false),
                    RushingOut = table.Column<byte>(type: "tinyint", nullable: false),
                    Sportmanship = table.Column<byte>(type: "tinyint", nullable: false),
                    Stamina = table.Column<byte>(type: "tinyint", nullable: false),
                    Strength = table.Column<byte>(type: "tinyint", nullable: false),
                    Tackling = table.Column<byte>(type: "tinyint", nullable: false),
                    Teamwork = table.Column<byte>(type: "tinyint", nullable: false),
                    Technique = table.Column<byte>(type: "tinyint", nullable: false),
                    Temperament = table.Column<byte>(type: "tinyint", nullable: false),
                    Throwing = table.Column<byte>(type: "tinyint", nullable: false),
                    TrendToPunch = table.Column<byte>(type: "tinyint", nullable: false),
                    Versatility = table.Column<byte>(type: "tinyint", nullable: false),
                    Vision = table.Column<byte>(type: "tinyint", nullable: false),
                    WorkRate = table.Column<byte>(type: "tinyint", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerAttributeSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Birthplace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerAttributeSetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_PlayerAttributeSets_PlayerAttributeSetId",
                        column: x => x.PlayerAttributeSetId,
                        principalTable: "PlayerAttributeSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_PlayerAttributeSetId",
                table: "Players",
                column: "PlayerAttributeSetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "PlayerAttributeSets");
        }
    }
}
