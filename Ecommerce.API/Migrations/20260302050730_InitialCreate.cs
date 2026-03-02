using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Điện thoại" },
                    { 2, "Laptop" },
                    { 3, "Phụ kiện" },
                    { 4, "Tablet" },
                    { 5, "Đồng hồ thông minh" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Content", "CreatedDate", "ImagePath", "Name", "OriginalPrice", "SalePrice" },
                values: new object[,]
                {
                    { 1, "Mô tả chi tiết sản phẩm iPhone 15 Pro Max. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7377), null, "iPhone 15 Pro Max", 35060000m, null },
                    { 2, "Mô tả chi tiết sản phẩm Samsung Galaxy S24 Ultra. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7391), null, "Samsung Galaxy S24 Ultra", 10640000m, 9044000.00m },
                    { 3, "Mô tả chi tiết sản phẩm Xiaomi 14 Pro. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7394), null, "Xiaomi 14 Pro", 12570000m, null },
                    { 4, "Mô tả chi tiết sản phẩm MacBook Air M3. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7397), "/uploads/MacBook-Air-M3-6.jpg", "MacBook Air M3", 37590000m, 31951500.00m },
                    { 5, "Mô tả chi tiết sản phẩm Dell XPS 15. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7400), null, "Dell XPS 15", 12810000m, 10888500.00m },
                    { 6, "Mô tả chi tiết sản phẩm Asus Zenbook 14. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7404), null, "Asus Zenbook 14", 15550000m, null },
                    { 7, "Mô tả chi tiết sản phẩm AirPods Pro 2. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7407), null, "AirPods Pro 2", 27750000m, null },
                    { 8, "Mô tả chi tiết sản phẩm Samsung Galaxy Buds 3. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7409), null, "Samsung Galaxy Buds 3", 22140000m, null },
                    { 9, "Mô tả chi tiết sản phẩm Logitech MX Master 3S. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7412), null, "Logitech MX Master 3S", 28280000m, null },
                    { 10, "Mô tả chi tiết sản phẩm iPad Pro M4. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7416), null, "iPad Pro M4", 41630000m, 35385500.00m },
                    { 11, "Mô tả chi tiết sản phẩm Samsung Galaxy Tab S9. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7419), null, "Samsung Galaxy Tab S9", 22880000m, null },
                    { 12, "Mô tả chi tiết sản phẩm Xiaomi Pad 6. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7422), null, "Xiaomi Pad 6", 9050000m, 7692500.00m },
                    { 13, "Mô tả chi tiết sản phẩm Apple Watch Series 9. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7425), null, "Apple Watch Series 9", 41720000m, 35462000.00m },
                    { 14, "Mô tả chi tiết sản phẩm Samsung Galaxy Watch 6. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7428), null, "Samsung Galaxy Watch 6", 6980000m, 5933000.00m },
                    { 15, "Mô tả chi tiết sản phẩm Garmin Venu 3. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7430), null, "Garmin Venu 3", 11640000m, 9894000.00m },
                    { 16, "Mô tả chi tiết sản phẩm Sony WH-1000XM5. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7433), null, "Sony WH-1000XM5", 36160000m, 30736000.00m },
                    { 17, "Mô tả chi tiết sản phẩm Anker PowerBank 20K. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7510), null, "Anker PowerBank 20K", 13380000m, null },
                    { 18, "Mô tả chi tiết sản phẩm Baseus USB-C Hub. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7517), null, "Baseus USB-C Hub", 18860000m, 16031000.00m },
                    { 19, "Mô tả chi tiết sản phẩm OPPO Find X7 Ultra. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7521), null, "OPPO Find X7 Ultra", 41940000m, null },
                    { 20, "Mô tả chi tiết sản phẩm Google Pixel 8 Pro. Sản phẩm chất lượng cao, bảo hành chính hãng.", new DateTime(2026, 3, 2, 12, 7, 29, 618, DateTimeKind.Local).AddTicks(7525), null, "Google Pixel 8 Pro", 29100000m, 24735000.00m }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 1, 7 },
                    { 3, 7 },
                    { 1, 8 },
                    { 3, 8 },
                    { 3, 9 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 12 },
                    { 1, 13 },
                    { 5, 13 },
                    { 1, 14 },
                    { 5, 14 },
                    { 5, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 1, 19 },
                    { 1, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
