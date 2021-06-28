using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chacha_project.Migrations
{
    public partial class Tabls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    AttendenceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Present = table.Column<string>(nullable: true),
                    Absent = table.Column<string>(nullable: true),
                    Leaves = table.Column<string>(nullable: true),
                    EnterTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.AttendenceId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(nullable: false),
                    FatherName = table.Column<string>(nullable: false),
                    StudentRelation = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Religion = table.Column<string>(nullable: false),
                    Nationality = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    RegistrationNo = table.Column<int>(nullable: false),
                    StudentCNIC = table.Column<string>(nullable: false),
                    Domicile = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
