using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegisterAPII.Migrations
{
    /// <inheritdoc />
    public partial class vvvvvvvvvvv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProfiles",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "NotificationCruds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descreption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRidden = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationCruds", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "");

            migrationBuilder.InsertData(
                table: "NotificationCruds",
                columns: new[] { "Id", "Date", "Descreption", "IsRidden", "Role", "Title" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description 1", false, "Role 1", "Notification 1" });

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 7, 33, 40, 463, DateTimeKind.Utc).AddTicks(1857));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationCruds");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StudentProfiles",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "ZCDFGBTJHWVSDWMNB");

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 27, 10, 5, 55, 866, DateTimeKind.Utc).AddTicks(7834));
        }
    }
}
