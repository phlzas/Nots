using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RegisterAPII.Migrations
{
    /// <inheritdoc />
    public partial class aaaaaaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BehaviorNotes_AttendanceRecords_AttendanceRecordId",
                table: "BehaviorNotes");

            migrationBuilder.DropIndex(
                name: "IX_BehaviorNotes_AttendanceRecordId",
                table: "BehaviorNotes");

            migrationBuilder.AddColumn<int>(
                name: "NoteId",
                table: "AttendanceRecords",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Side Talks" },
                    { 2, "Eating" },
                    { 3, "Late" }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 15, 7, 11, 619, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_NoteId",
                table: "AttendanceRecords",
                column: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceRecords_Notes_NoteId",
                table: "AttendanceRecords",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceRecords_Notes_NoteId",
                table: "AttendanceRecords");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_AttendanceRecords_NoteId",
                table: "AttendanceRecords");

            migrationBuilder.DropColumn(
                name: "NoteId",
                table: "AttendanceRecords");

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.CreateIndex(
                name: "IX_BehaviorNotes_AttendanceRecordId",
                table: "BehaviorNotes",
                column: "AttendanceRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_BehaviorNotes_AttendanceRecords_AttendanceRecordId",
                table: "BehaviorNotes",
                column: "AttendanceRecordId",
                principalTable: "AttendanceRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
