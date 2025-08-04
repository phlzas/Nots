using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegisterAPII.Migrations
{
    /// <inheritdoc />
    public partial class ttttttttttt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbsenceRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Session = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbsenceRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 3, 7, 53, 11, 390, DateTimeKind.Utc).AddTicks(4403));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbsenceRecords");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 356, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 29, 12, 19, 9, 357, DateTimeKind.Utc).AddTicks(3056));
        }
    }
}
