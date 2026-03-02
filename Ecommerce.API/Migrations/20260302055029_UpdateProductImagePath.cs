using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductImagePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4760), "/uploads/MacBook-Air-M3-6.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 50, 29, 116, DateTimeKind.Local).AddTicks(4831));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7397), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7525));
        }
    }
}
