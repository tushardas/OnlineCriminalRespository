using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace OnlineCrimeRepo.Migrations
{
    public partial class updatedCop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CopID",
                table: "Cop",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CopID",
                table: "Cop",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
