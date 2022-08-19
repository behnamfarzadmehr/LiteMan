using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lernkartei.Infrastructure.Migrations
{
    public partial class addcreateDateTimecard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateTime",
                schema: "Crd",
                table: "Card",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Date",
                schema: "Crd",
                table: "Card",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDateTime",
                schema: "Crd",
                table: "Card");

            migrationBuilder.DropColumn(
                name: "Date",
                schema: "Crd",
                table: "Card");
        }
    }
}
