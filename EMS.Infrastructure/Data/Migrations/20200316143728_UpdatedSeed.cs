using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMS.Infrastructure.Data.Migrations
{
    public partial class UpdatedSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ManagerGuid",
                table: "Employees",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EmployeeGuid", "ManagerGuid" },
                values: new object[] { new Guid("67faf954-a542-41a7-a5f7-d5b041511a07"), new Guid("783e92f6-85c0-48cd-9a09-c25beafc570c") });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EmployeeGuid", "ManagerGuid" },
                values: new object[] { new Guid("f62625cd-962c-4c14-a3f4-bafa8bb22e50"), new Guid("783e92f6-85c0-48cd-9a09-c25beafc570c") });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EmployeeGuid", "ManagerGuid" },
                values: new object[] { new Guid("b13be80f-f491-44b7-81e9-0693bcd866ba"), new Guid("783e92f6-85c0-48cd-9a09-c25beafc570c") });

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ManagerGuid",
                value: new Guid("783e92f6-85c0-48cd-9a09-c25beafc570c"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManagerGuid",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmployeeGuid",
                value: new Guid("22f60d0a-54a3-4a12-854d-43225b5d281f"));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "EmployeeGuid",
                value: new Guid("ac20b57a-2445-4437-96fe-4860b6b16c1f"));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "EmployeeGuid",
                value: new Guid("6cbb3bdb-91a4-45ab-951a-fca56806a797"));

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ManagerGuid",
                value: new Guid("a22fdbcd-b327-4412-bb02-291aca709752"));
        }
    }
}
