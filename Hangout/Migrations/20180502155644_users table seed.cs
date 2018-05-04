using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Hangout.Migrations
{
    public partial class userstableseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Users(Username, Password, FirstName, LastName) Values ('AkaliMid', 'kow90dsss', 'Kali', 'Champion');");
            migrationBuilder.Sql("Insert Into Users(Username, Password, FirstName, LastName) Values ('DeeAreGee', 'c4ntCo5e', 'David', 'Guhl');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
