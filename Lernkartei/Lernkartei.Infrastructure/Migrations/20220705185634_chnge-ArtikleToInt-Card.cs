using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lernkartei.Infrastructure.Migrations
{
    public partial class chngeArtikleToIntCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Artikle",
                schema: "Crd",
                table: "Card",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Artikle",
                schema: "Crd",
                table: "Card",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
