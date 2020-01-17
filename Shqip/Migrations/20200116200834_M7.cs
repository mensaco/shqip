using Microsoft.EntityFrameworkCore.Migrations;

namespace Shqip.Migrations
{
    public partial class M7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rase_RasatShumesPaShquarId",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "PaShquar",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "Shquar",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "Shumesi",
                table: "Emrat");

            migrationBuilder.RenameColumn(
                name: "RasatShumesPaShquarId",
                table: "Emrat",
                newName: "RasatShumesPashquarId");

            migrationBuilder.RenameIndex(
                name: "IX_Emrat_RasatShumesPaShquarId",
                table: "Emrat",
                newName: "IX_Emrat_RasatShumesPashquarId");

            migrationBuilder.AddColumn<string>(
                name: "NjejesiPashquar",
                table: "Emrat",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NjejesiShquar",
                table: "Emrat",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShumesiPashquar",
                table: "Emrat",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShumesiShquar",
                table: "Emrat",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Emrat_Rase_RasatShumesPashquarId",
                table: "Emrat",
                column: "RasatShumesPashquarId",
                principalTable: "Rase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rase_RasatShumesPashquarId",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "NjejesiPashquar",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "NjejesiShquar",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "ShumesiPashquar",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "ShumesiShquar",
                table: "Emrat");

            migrationBuilder.RenameColumn(
                name: "RasatShumesPashquarId",
                table: "Emrat",
                newName: "RasatShumesPaShquarId");

            migrationBuilder.RenameIndex(
                name: "IX_Emrat_RasatShumesPashquarId",
                table: "Emrat",
                newName: "IX_Emrat_RasatShumesPaShquarId");

            migrationBuilder.AddColumn<string>(
                name: "PaShquar",
                table: "Emrat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shquar",
                table: "Emrat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shumesi",
                table: "Emrat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Emrat_Rase_RasatShumesPaShquarId",
                table: "Emrat",
                column: "RasatShumesPaShquarId",
                principalTable: "Rase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
