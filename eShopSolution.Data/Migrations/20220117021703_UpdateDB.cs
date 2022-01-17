using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "4cf0c829-e2bc-4588-8862-f6416f99b0e2");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4e76e3c-0168-4d49-8099-06a692e5fb22", "AQAAAAEAACcQAAAAEJtYOMPU6/3ZL/lcmFzFZVKJMpogFttjysOOevo7SQPsnD1QT3nIBPdLMACsOs1+dQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 1, 17, 9, 17, 2, 696, DateTimeKind.Local).AddTicks(867));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0d047540-92cb-4a02-8656-ba06aafe4c6f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea745bdc-bad8-4337-b7c2-9e43847c4fb2", "AQAAAAEAACcQAAAAECXbW346r+joohXnzwS/qH2GiPdFqh9zJtGVCPp/CMGdZ1b93Iu0VNN6SbHGEgZfCQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 30, 11, 39, 7, 497, DateTimeKind.Local).AddTicks(1954));
        }
    }
}
