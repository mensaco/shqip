using Microsoft.EntityFrameworkCore.Migrations;

namespace Shqip.Migrations
{
    public partial class M3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pershkrim");

            migrationBuilder.DropTable(
                name: "Fjale");

            migrationBuilder.AddColumn<string>(
                name: "Antonimet",
                table: "Emrat",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pershkrimet",
                table: "Emrat",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sinonimet",
                table: "Emrat",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeNgjashme",
                table: "Emrat",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Antonimet",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "Pershkrimet",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "Sinonimet",
                table: "Emrat");

            migrationBuilder.DropColumn(
                name: "TeNgjashme",
                table: "Emrat");

            migrationBuilder.CreateTable(
                name: "Fjale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmerId = table.Column<int>(type: "int", nullable: true),
                    EmerId1 = table.Column<int>(type: "int", nullable: true),
                    EmerId2 = table.Column<int>(type: "int", nullable: true),
                    KontribuesiID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Teksti = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fjale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fjale_Emrat_EmerId",
                        column: x => x.EmerId,
                        principalTable: "Emrat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fjale_Emrat_EmerId1",
                        column: x => x.EmerId1,
                        principalTable: "Emrat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fjale_Emrat_EmerId2",
                        column: x => x.EmerId2,
                        principalTable: "Emrat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pershkrim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmerId = table.Column<int>(type: "int", nullable: true),
                    FjaleId = table.Column<int>(type: "int", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pershkrim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pershkrim_Emrat_EmerId",
                        column: x => x.EmerId,
                        principalTable: "Emrat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pershkrim_Fjale_FjaleId",
                        column: x => x.FjaleId,
                        principalTable: "Fjale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fjale_EmerId",
                table: "Fjale",
                column: "EmerId");

            migrationBuilder.CreateIndex(
                name: "IX_Fjale_EmerId1",
                table: "Fjale",
                column: "EmerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Fjale_EmerId2",
                table: "Fjale",
                column: "EmerId2");

            migrationBuilder.CreateIndex(
                name: "IX_Pershkrim_EmerId",
                table: "Pershkrim",
                column: "EmerId");

            migrationBuilder.CreateIndex(
                name: "IX_Pershkrim_FjaleId",
                table: "Pershkrim",
                column: "FjaleId");
        }
    }
}
