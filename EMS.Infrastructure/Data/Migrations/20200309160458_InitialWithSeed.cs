using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMS.Infrastructure.Data.Migrations
{
    public partial class InitialWithSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManagerGuid = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeGuid = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Department = table.Column<string>(nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    ManagerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "ManagerGuid" },
                values: new object[] { 1, 24, "Manager", "One", new Guid("a22fdbcd-b327-4412-bb02-291aca709752") });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "Department", "EmployeeGuid", "FirstName", "LastName", "ManagerId", "Salary" },
                values: new object[] { 1, 20, "Development", new Guid("22f60d0a-54a3-4a12-854d-43225b5d281f"), "Employee", "One", 1, 5000m });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "Department", "EmployeeGuid", "FirstName", "LastName", "ManagerId", "Salary" },
                values: new object[] { 2, 22, "HR", new Guid("ac20b57a-2445-4437-96fe-4860b6b16c1f"), "Employee", "Two", 1, 2000m });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "Department", "EmployeeGuid", "FirstName", "LastName", "ManagerId", "Salary" },
                values: new object[] { 3, 27, "Security", new Guid("6cbb3bdb-91a4-45ab-951a-fca56806a797"), "Employee", "Three", 1, 7000m });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ManagerId",
                table: "Employees",
                column: "ManagerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Managers");
        }
    }
}
