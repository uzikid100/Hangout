using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using Hangout.Models;

namespace Hangout.Migrations
{
    public partial class FriendSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {





            //User test = new User()
            //{
            //    Username = "spongeBobSquareFace",
            //    Password = "password",
            //    FirstName = "spongeBob",
            //    LastName = "SquarePants",
            //};

            //migrationBuilder.InsertData("Friends", new[] { "Id", "UserId", "User" }, new object[] { 1, 2, test });
            //migrationBuilder.Sql("INSERT INTO Friends(Id, User) VALUES (1, test);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
