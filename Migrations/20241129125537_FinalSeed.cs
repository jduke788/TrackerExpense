using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackerExpense.Server.Migrations
{
    public partial class FinalSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "CreatedAt", "Description", "Title" },
                values: new object[] { 65.0m, new DateTime(2024, 11, 29, 12, 55, 37, 363, DateTimeKind.Utc).AddTicks(595), "Petrol at Tesco", "Transport" });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "CreatedAt", "Description", "Title" },
                values: new object[] { 3.6m, new DateTime(2024, 11, 29, 13, 55, 37, 363, DateTimeKind.Utc).AddTicks(598), "Meal deal from Tesco for lunch", "Eating out" });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "CreatedAt", "Description", "Title" },
                values: new object[] { 84.32m, new DateTime(2024, 11, 29, 14, 55, 37, 363, DateTimeKind.Utc).AddTicks(603), "Weekly shop - Tesco", "Groceries" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "CreatedAt", "Description", "Title" },
                values: new object[] { 10.0m, new DateTime(2024, 11, 28, 20, 11, 22, 530, DateTimeKind.Utc).AddTicks(8064), "", "Bought a Snack" });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "CreatedAt", "Description", "Title" },
                values: new object[] { 100.0m, new DateTime(2024, 11, 28, 21, 11, 22, 530, DateTimeKind.Utc).AddTicks(8067), "", "Bought a phone" });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "CreatedAt", "Description", "Title" },
                values: new object[] { 20.0m, new DateTime(2024, 11, 28, 22, 11, 22, 530, DateTimeKind.Utc).AddTicks(8072), "", "Bought Lunch" });
        }
    }
}
