using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShelf.Migrations
{
    public partial class sand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6166b81-a817-4e17-9617-91f383de17d8", "AQAAAAEAACcQAAAAEA7eOGyUgH1rfYSLo/XWCgVuBzs41lNji99pAYtqmwfsDzm+yohMW0CKjnF/ju98xA==" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApplicationUserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApplicationUserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "ApplicationUserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c88bfc9-2725-4021-be20-371a346c8db1", "AQAAAAEAACcQAAAAEPWKYNFFchjRpFlKsnj2zLaGXNaKtAvq/lYjVvPNXaLEAuBigux491R/396/sPKKMA==" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "ApplicationUserId",
                value: null);
        }
    }
}
