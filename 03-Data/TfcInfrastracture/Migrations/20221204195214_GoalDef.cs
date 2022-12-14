using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TfcInfrastracture.Migrations
{
    public partial class GoalDef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_PlayerAttributeSets_PlayerAttributeSetId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_PlayerAttributeSetId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PlayerAttributeSetId",
                table: "Players");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerAttributeSets_PlayerID",
                table: "PlayerAttributeSets",
                column: "PlayerID");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerAttributeSets_Players_PlayerID",
                table: "PlayerAttributeSets",
                column: "PlayerID",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerAttributeSets_Players_PlayerID",
                table: "PlayerAttributeSets");

            migrationBuilder.DropIndex(
                name: "IX_PlayerAttributeSets_PlayerID",
                table: "PlayerAttributeSets");

            migrationBuilder.AddColumn<int>(
                name: "PlayerAttributeSetId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Players_PlayerAttributeSetId",
                table: "Players",
                column: "PlayerAttributeSetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_PlayerAttributeSets_PlayerAttributeSetId",
                table: "Players",
                column: "PlayerAttributeSetId",
                principalTable: "PlayerAttributeSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
