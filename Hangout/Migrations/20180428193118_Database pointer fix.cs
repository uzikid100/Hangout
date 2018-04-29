using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Hangout.Migrations
{
    public partial class Databasepointerfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFree",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "NumberOfAttendees",
                table: "Events",
                newName: "Attending");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "Attending",
                table: "Events",
                newName: "NumberOfAttendees");

            migrationBuilder.AddColumn<bool>(
                name: "IsFree",
                table: "Events",
                nullable: false,
                defaultValue: false);
        }
    }
}
