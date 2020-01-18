using Microsoft.EntityFrameworkCore.Migrations;

namespace Shqip.Migrations
{
    public partial class OptimizeMaxLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rase_RasatNjejesPashquarId",
                table: "Emrat");

            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rase_RasatNjejesShquarId",
                table: "Emrat");

            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rase_RasatShumesPashquarId",
                table: "Emrat");

            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rase_RasatShumesShquarId",
                table: "Emrat");

            migrationBuilder.DropTable(
                name: "Rase");

            migrationBuilder.AlterColumn<string>(
                name: "Teksti",
                table: "Emrat",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TeNgjashme",
                table: "Emrat",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sinonimet",
                table: "Emrat",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShumesiShquar",
                table: "Emrat",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShumesiPashquar",
                table: "Emrat",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pershkrimet",
                table: "Emrat",
                maxLength: 511,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NjejesiShquar",
                table: "Emrat",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NjejesiPashquar",
                table: "Emrat",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KontribuesiID",
                table: "Emrat",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Antonimet",
                table: "Emrat",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KategoriaGramatikore",
                table: "Emrat",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Vendbanimi",
                table: "AspNetUsers",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titulli",
                table: "AspNetUsers",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Rasa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emerore = table.Column<string>(maxLength: 30, nullable: true),
                    Gjinore = table.Column<string>(maxLength: 30, nullable: true),
                    Dhanore = table.Column<string>(maxLength: 30, nullable: true),
                    Kallzore = table.Column<string>(maxLength: 30, nullable: true),
                    Rrjedhore = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rasa", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Emrat_Rasa_RasatNjejesPashquarId",
                table: "Emrat",
                column: "RasatNjejesPashquarId",
                principalTable: "Rasa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emrat_Rasa_RasatNjejesShquarId",
                table: "Emrat",
                column: "RasatNjejesShquarId",
                principalTable: "Rasa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emrat_Rasa_RasatShumesPashquarId",
                table: "Emrat",
                column: "RasatShumesPashquarId",
                principalTable: "Rasa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emrat_Rasa_RasatShumesShquarId",
                table: "Emrat",
                column: "RasatShumesShquarId",
                principalTable: "Rasa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rasa_RasatNjejesPashquarId",
                table: "Emrat");

            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rasa_RasatNjejesShquarId",
                table: "Emrat");

            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rasa_RasatShumesPashquarId",
                table: "Emrat");

            migrationBuilder.DropForeignKey(
                name: "FK_Emrat_Rasa_RasatShumesShquarId",
                table: "Emrat");

            migrationBuilder.DropTable(
                name: "Rasa");

            migrationBuilder.DropColumn(
                name: "KategoriaGramatikore",
                table: "Emrat");

            migrationBuilder.AlterColumn<string>(
                name: "Teksti",
                table: "Emrat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TeNgjashme",
                table: "Emrat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sinonimet",
                table: "Emrat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShumesiShquar",
                table: "Emrat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShumesiPashquar",
                table: "Emrat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pershkrimet",
                table: "Emrat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 511,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NjejesiShquar",
                table: "Emrat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NjejesiPashquar",
                table: "Emrat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KontribuesiID",
                table: "Emrat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Antonimet",
                table: "Emrat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Vendbanimi",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titulli",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Rase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dhanore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emerore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gjinore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kallzore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rrjedhore = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rase", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Emrat_Rase_RasatNjejesPashquarId",
                table: "Emrat",
                column: "RasatNjejesPashquarId",
                principalTable: "Rase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emrat_Rase_RasatNjejesShquarId",
                table: "Emrat",
                column: "RasatNjejesShquarId",
                principalTable: "Rase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emrat_Rase_RasatShumesPashquarId",
                table: "Emrat",
                column: "RasatShumesPashquarId",
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
    }
}
