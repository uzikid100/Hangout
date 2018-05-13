using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Hangout.Migrations
{
    public partial class DbSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Users(Username, Password, FirstName, LastName, Email) Values ('Uzikid100', 'myAPpDev', 'Uzezi', 'Ogodo', 'Uzeziogodo@yahoo.com');");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
