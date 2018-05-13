using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Hangout.Migrations
{
    public partial class UserSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Avatar",
                table: "Users",
                type: "VARCHAR(255)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.Sql("Insert Into Users(Username, Password, FirstName, LastName, Email, Avatar) Values ('ToastyBuns', 'mypassWOerd', 'Chris', 'Toasty', 'Buns@toasty.com', 'default-3');");
            migrationBuilder.Sql("Insert Into Users(Username, Password, FirstName, LastName, Email, Avatar) Values ('CDubbsOnfiddy', 'dubbinOn4m', 'Christian', 'Dubllin', 'CDubbin@staep.com', 'default-2');");
            migrationBuilder.Sql("Insert Into Users(Username, Password, FirstName, LastName, Email, Avatar) Values ('SnoopLion', 'KushMyCologne', 'Snoop', 'Dogg', 'Snizzle@getLit.org', 'default-1');");
            migrationBuilder.Sql("Insert Into Users(Username, Password, FirstName, LastName, Email, Avatar) Values ('OchoCinco', 'b4astMod33', 'Chad', 'Ocho-Cinco', 'chad@NFL.com', 'default-3');");
            migrationBuilder.Sql("Insert Into Users(Username, Password, FirstName, LastName, Email, Avatar) Values ('OdeezNuts', 'delBeckahm', 'ODell', 'Beckham', 'ODell@NFL.com', 'default-2');");
            migrationBuilder.Sql("Insert Into Users(Username, Password, FirstName, LastName, Email, Avatar) Values ('DeeAreGee', 'c4ntCo5e', 'David', 'Guhl', 'gamesAreLife@yahoo.com','default-1');");
            migrationBuilder.Sql("Insert Into Users(Username, Password, FirstName, LastName, Email, Avatar) Values ('Brandice_92', '999dddggghhh', 'Candice', 'Basco', 'weird@weird.com', 'default-3');");
            migrationBuilder.Sql("Insert Into Users(Username, Password, FirstName, LastName, Email, Avatar) Values ('AkaliMid', 'kow90dsss', 'Kali', 'Champion', 'Akali@weFixit.com', 'default-2');");
            migrationBuilder.Sql("Insert Into Users(Username, Password, FirstName, LastName, Email, Avatar) Values ('MikeWillMadeIt', 'iMakeBeatzzz', 'Mike', 'Will', 'MikeWill@theBeatplug.com', 'default-3');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Avatar",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)",
                oldNullable: true);
        }
    }
}
