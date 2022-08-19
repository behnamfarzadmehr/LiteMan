using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lernkartei.Infrastructure.Migrations
{
    public partial class tablecardHause : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardHouse",
                schema: "Crd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<long>(type: "bigint", nullable: false),
                    House = table.Column<int>(type: "int", nullable: false),
                    ActionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardHouse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardHouse_Card_CardId",
                        column: x => x.CardId,
                        principalSchema: "Crd",
                        principalTable: "Card",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardHouse_CardId",
                schema: "Crd",
                table: "CardHouse",
                column: "CardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardHouse",
                schema: "Crd");
        }
    }
}
