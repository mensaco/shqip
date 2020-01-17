using Microsoft.EntityFrameworkCore.Migrations;

namespace Shqip.Migrations
{
    public partial class M6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RasatNjejesShquarId",
                table: "Emrat",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RasatShumesShquarId",
                table: "Emrat",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emrat_RasatNjejesShquarId",
                table: "Emrat",
                column: "RasatNjejesShquarId");

            migrationBuilder.CreateIndex(
                name: "IX_Emrat_RasatShumesShquarId",
                table: "Emrat",
                column: "RasatShumesShquarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emrat_Rase_RasatNjejesShquarId",
                table: "Emrat",
                column: "RasatNjejesShquarId",
                principalTable: "Rase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emrat_Rase_RasatShumesShquarId",
                table: "Emrat",
                column: "RasatShumesShquarId",
                principalTable: "Rase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rase_RasatNjejesShquarId",
                table: "Emrat");

            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rase_RasatShumesShquarId",
                table: "Emrat");

            migrationBuilder.DropIndex(
                name: "IX_Emrat_RasatNjejesShquarId",
                table: "Emrat");

            migrationBuilder.DropIndex(
                name: "IX_Emrat_RasatShumesShquarId",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "RasatNjejesShquarId",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "RasatShumesShquarId",
                table: "Emrat");
        }
    }
}
