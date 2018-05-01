using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Hangout.Migrations
{
    public partial class Seedusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Users(Username, Password, FirstName, LastName) Values ('testUser', 'password123', 'test', 'user');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
