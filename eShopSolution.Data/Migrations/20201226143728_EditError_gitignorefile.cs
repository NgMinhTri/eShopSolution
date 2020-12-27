using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class EditError_gitignorefile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 26, 21, 37, 27, 828, DateTimeKind.Local).AddTicks(6715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 16, 9, 36, 7, 45, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b2aeae45-ea70-4eff-8119-6188be2e5d68");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea4c080e-7632-434c-9620-aa7dd4dca06d", "AQAAAAEAACcQAAAAEF692AWwbYqZPtK8ySIRWLGPY5q6SU9ybOPpVMES6R1QOoqS2bBZ2S5p9SdZsjxR8A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 26, 21, 37, 27, 848, DateTimeKind.Local).AddTicks(3455));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 16, 9, 36, 7, 45, DateTimeKind.Local).AddTicks(9597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 26, 21, 37, 27, 828, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "716626d8-5dea-4776-9f3b-e9e6316ba0e5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "35f55e7e-6856-4edc-b7ab-b1ef5daeb2c6", "AQAAAAEAACcQAAAAEDXAHpCkUVyajvmvspH5oF3JjYaGaJEQMTu1ZcAcp5kZUlHVD8TiGok903eGuqXhhw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 16, 9, 36, 7, 74, DateTimeKind.Local).AddTicks(891));
        }
    }
}
