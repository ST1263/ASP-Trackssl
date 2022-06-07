using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace trackssl.Migrations.TrackSSLDB
{
    public partial class Updatemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAT",
                table: "Domain",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAT",
                table: "Domain");
        }
    }
}
