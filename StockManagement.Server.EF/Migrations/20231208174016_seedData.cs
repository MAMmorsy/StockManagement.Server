using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StockManagement.Server.EF.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "StockId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Vianet", 45.84m },
                    { 2, "Agritek", 13.25m },
                    { 3, "Akamai", 80.29m },
                    { 4, "Baidu", 74.10m },
                    { 5, "Blinkx", 89.96m },
                    { 6, "Blucora", 79.1m },
                    { 7, "Boingo", 17.84m },
                    { 8, "Brainybrawn", 76.26m },
                    { 9, "Carbonite", 65.17m },
                    { 10, "China Finance", 8.69m },
                    { 11, "ChinaCache", 48.22m },
                    { 12, "ADR", 67.97m },
                    { 13, "ChitrChatr", 66.91m },
                    { 14, "Cnova", 68.12m },
                    { 15, "Cogent", 65.83m },
                    { 16, "Crexendo", 5.14m },
                    { 17, "CrowdGather", 95.31m },
                    { 18, "EarthLink", 90.83m },
                    { 19, "Eastern", 57.43m },
                    { 20, "ENDEXX", 57.93m },
                    { 21, "Envestnet", 89.75m },
                    { 22, "Epazz", 56.45m },
                    { 23, "FlashZero", 84.69m },
                    { 24, "Genesis", 25.51m },
                    { 25, "InterNAP", 43.46m },
                    { 26, "MeetMe", 38.97m },
                    { 27, "Netease", 49.58m },
                    { 28, "Qihoo", 50.68m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 28);
        }
    }
}
