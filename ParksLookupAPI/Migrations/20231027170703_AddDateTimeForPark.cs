using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksLookupAPI.Migrations
{
    public partial class AddDateTimeForPark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EstablishedAsPark",
                table: "Parks",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "onr",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7345f06-5ffd-45a3-a9f4-65c19e88d865", "AQAAAAEAACcQAAAAEJsqAUYMuC2CLkUmFwdpeweGIlpCjG6vfrEtOpghn1zahN//dDE4EBRmEL8qRBp60w==", "5d6c3e52-4a42-4d56-bd3e-8db4115f9c1c" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                column: "EstablishedAsPark",
                value: new DateTime(1915, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2,
                column: "EstablishedAsPark",
                value: new DateTime(1968, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                column: "EstablishedAsPark",
                value: new DateTime(1899, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                column: "EstablishedAsPark",
                value: new DateTime(1902, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstablishedAsPark",
                table: "Parks");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "onr",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34f82fb9-c37b-47e7-8bc7-c886e916bbe6", "AQAAAAEAACcQAAAAEFd1YnCR3t9/HUkNC4MYkD+tcQH7TNlxK3zBNMgF3sV/w4QtMjZZAHIgqX4+4OJRGQ==", "d8ed9565-4870-4dda-a3e2-d188fb777b8f" });
        }
    }
}
