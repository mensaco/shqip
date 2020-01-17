using Microsoft.EntityFrameworkCore.Migrations;

namespace Shqip.Migrations
{
    public partial class M5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rase_RasatNjejesId",
                table: "Emrat");

            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rase_RasatShumesId",
                table: "Emrat");

            migrationBuilder.DropIndex(
                name: "IX_Emrat_RasatNjejesId",
                table: "Emrat");

            migrationBuilder.DropIndex(
                name: "IX_Emrat_RasatShumesId",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "RasatNjejesId",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "RasatShumesId",
                table: "Emrat");

            migrationBuilder.AddColumn<int>(
                name: "RasatNjejesPashquarId",
                table: "Emrat",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RasatShumesPaShquarId",
                table: "Emrat",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emrat_RasatNjejesPashquarId",
                table: "Emrat",
                column: "RasatNjejesPashquarId");

            migrationBuilder.CreateIndex(
                name: "IX_Emrat_RasatShumesPaShquarId",
                table: "Emrat",
                column: "RasatShumesPaShquarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emrat_Rase_RasatNjejesPashquarId",
                table: "Emrat",
                column: "RasatNjejesPashquarId",
                principalTable: "Rase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emrat_Rase_RasatShumesPaShquarId",
                table: "Emrat",
                column: "RasatShumesPaShquarId",
                principalTable: "Rase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rase_RasatNjejesPashquarId",
                table: "Emrat");

            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rase_RasatShumesPaShquarId",
                table: "Emrat");

            migrationBuilder.DropIndex(
                name: "IX_Emrat_RasatNjejesPashquarId",
                table: "Emrat");

            migrationBuilder.DropIndex(
                name: "IX_Emrat_RasatShumesPaShquarId",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "RasatNjejesPashquarId",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "RasatShumesPaShquarId",
                table: "Emrat");

            migrationBuilder.AddColumn<int>(
                name: "RasatNjejesId",
                table: "Emrat",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RasatShumesId",
                table: "Emrat",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emrat_RasatNjejesId",
                table: "Emrat",
                column: "RasatNjejesId");

            migrationBuilder.CreateIndex(
                name: "IX_Emrat_RasatShumesId",
                table: "Emrat",
                column: "RasatShumesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emrat_Rase_RasatNjejesId",
                table: "Emrat",
                column: "RasatNjejesId",
                principalTable: "Rase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emrat_Rase_RasatShumesId",
                table: "Emrat",
                column: "RasatShumesId",
                principalTable: "Rase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
