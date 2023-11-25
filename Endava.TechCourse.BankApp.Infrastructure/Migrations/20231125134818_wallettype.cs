using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Endava.TechCourse.BankApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class wallettype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("170f25fa-5f43-406b-80be-9172717f792d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e6ed386f-4a9d-4bc1-af44-e01d1dcc7f15"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("fd713fc8-3739-49af-add9-cf96f49fdd87"));

            migrationBuilder.AddColumn<int>(
                name: "WalletType",
                table: "Wallets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("5cc7b2ac-6ed4-44ad-887c-4504c34d36e3"), null, "Admin", "Admin" },
                    { new Guid("874cbd40-2e43-4584-90e3-3f47d427e6cb"), null, "User", "User" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CanBeRemoved", "ChangeRate", "CurrencyCode", "Name" },
                values: new object[] { new Guid("6e1404cd-461b-47a8-95ce-3d517b0c68f1"), false, 1m, "MDL", "Leu Moldovenesc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5cc7b2ac-6ed4-44ad-887c-4504c34d36e3"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("874cbd40-2e43-4584-90e3-3f47d427e6cb"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("6e1404cd-461b-47a8-95ce-3d517b0c68f1"));

            migrationBuilder.DropColumn(
                name: "WalletType",
                table: "Wallets");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("170f25fa-5f43-406b-80be-9172717f792d"), null, "Admin", "Admin" },
                    { new Guid("e6ed386f-4a9d-4bc1-af44-e01d1dcc7f15"), null, "User", "User" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CanBeRemoved", "ChangeRate", "CurrencyCode", "Name" },
                values: new object[] { new Guid("fd713fc8-3739-49af-add9-cf96f49fdd87"), false, 1m, "MDL", "Leu Moldovenesc" });
        }
    }
}
