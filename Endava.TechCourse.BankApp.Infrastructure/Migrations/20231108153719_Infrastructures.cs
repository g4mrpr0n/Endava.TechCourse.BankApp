﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Endava.TechCourse.BankApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Infrastructures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("84147554-f843-4a4f-a13f-039da2672e30"), null, "User", null },
                    { new Guid("cd42bb69-e5a3-41bb-9883-47913467ae5c"), null, "Admin", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("84147554-f843-4a4f-a13f-039da2672e30"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd42bb69-e5a3-41bb-9883-47913467ae5c"));
        }
    }
}
