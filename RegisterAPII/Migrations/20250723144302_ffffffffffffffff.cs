using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RegisterAPII.Migrations
{
    /// <inheritdoc />
    public partial class ffffffffffffffff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttendanceRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SessionNumber = table.Column<int>(type: "int", nullable: false),
                    IsPresent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BehaviorNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendanceRecordId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoteType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BehaviorNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BehaviorNotes_AttendanceRecords_AttendanceRecordId",
                        column: x => x.AttendanceRecordId,
                        principalTable: "AttendanceRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Junior 1");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Junior 2");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Junior 3");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Junior 4");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Wheeler 1");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Wheeler 2");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Wheeler 3");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Wheeler 4");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Senior 1");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Senior 2");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Senior 3");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Senior 4");

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Junior");

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Wheeler");

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Senior");

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClassId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9038), "Student 1 in Junior 1" });

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClassId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9041), "Student 2 in Junior 1" });

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClassId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9042), "Student 3 in Junior 1" });

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClassId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9043), "Student 4 in Junior 1" });

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClassId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9043), "Student 5 in Junior 1" });

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClassId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9044), "Student 6 in Junior 1" });

            migrationBuilder.InsertData(
                table: "StudentProfiles",
                columns: new[] { "Id", "Age", "City", "ClassId", "Country", "CreatedAt", "DaysAbsent", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 7, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9045), 0, null, "Student 7 in Junior 1", null },
                    { 8, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9046), 0, null, "Student 8 in Junior 1", null },
                    { 9, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9047), 0, null, "Student 9 in Junior 1", null },
                    { 10, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9048), 0, null, "Student 10 in Junior 1", null },
                    { 11, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9049), 0, null, "Student 11 in Junior 1", null },
                    { 12, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9050), 0, null, "Student 12 in Junior 1", null },
                    { 13, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9050), 0, null, "Student 13 in Junior 1", null },
                    { 14, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9052), 0, null, "Student 14 in Junior 1", null },
                    { 15, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9053), 0, null, "Student 15 in Junior 1", null },
                    { 16, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9054), 0, null, "Student 16 in Junior 1", null },
                    { 17, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9054), 0, null, "Student 17 in Junior 1", null },
                    { 18, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9055), 0, null, "Student 18 in Junior 1", null },
                    { 19, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9056), 0, null, "Student 19 in Junior 1", null },
                    { 20, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9057), 0, null, "Student 20 in Junior 1", null },
                    { 21, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9058), 0, null, "Student 21 in Junior 1", null },
                    { 22, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9058), 0, null, "Student 22 in Junior 1", null },
                    { 23, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9059), 0, null, "Student 23 in Junior 1", null },
                    { 24, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9060), 0, null, "Student 24 in Junior 1", null },
                    { 25, 0, null, 1, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9061), 0, null, "Student 25 in Junior 1", null },
                    { 26, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9062), 0, null, "Student 26 in Junior 2", null },
                    { 27, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9063), 0, null, "Student 27 in Junior 2", null },
                    { 28, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9064), 0, null, "Student 28 in Junior 2", null },
                    { 29, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9065), 0, null, "Student 29 in Junior 2", null },
                    { 30, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9065), 0, null, "Student 30 in Junior 2", null },
                    { 31, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9066), 0, null, "Student 31 in Junior 2", null },
                    { 32, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9067), 0, null, "Student 32 in Junior 2", null },
                    { 33, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9068), 0, null, "Student 33 in Junior 2", null },
                    { 34, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9069), 0, null, "Student 34 in Junior 2", null },
                    { 35, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9070), 0, null, "Student 35 in Junior 2", null },
                    { 36, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9071), 0, null, "Student 36 in Junior 2", null },
                    { 37, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9072), 0, null, "Student 37 in Junior 2", null },
                    { 38, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9072), 0, null, "Student 38 in Junior 2", null },
                    { 39, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9073), 0, null, "Student 39 in Junior 2", null },
                    { 40, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9074), 0, null, "Student 40 in Junior 2", null },
                    { 41, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9075), 0, null, "Student 41 in Junior 2", null },
                    { 42, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9076), 0, null, "Student 42 in Junior 2", null },
                    { 43, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9076), 0, null, "Student 43 in Junior 2", null },
                    { 44, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9077), 0, null, "Student 44 in Junior 2", null },
                    { 45, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9078), 0, null, "Student 45 in Junior 2", null },
                    { 46, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9080), 0, null, "Student 46 in Junior 2", null },
                    { 47, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9081), 0, null, "Student 47 in Junior 2", null },
                    { 48, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9082), 0, null, "Student 48 in Junior 2", null },
                    { 49, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9082), 0, null, "Student 49 in Junior 2", null },
                    { 50, 0, null, 2, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9083), 0, null, "Student 50 in Junior 2", null },
                    { 51, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9084), 0, null, "Student 51 in Junior 3", null },
                    { 52, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9085), 0, null, "Student 52 in Junior 3", null },
                    { 53, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9086), 0, null, "Student 53 in Junior 3", null },
                    { 54, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9164), 0, null, "Student 54 in Junior 3", null },
                    { 55, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9165), 0, null, "Student 55 in Junior 3", null },
                    { 56, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9166), 0, null, "Student 56 in Junior 3", null },
                    { 57, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9167), 0, null, "Student 57 in Junior 3", null },
                    { 58, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9168), 0, null, "Student 58 in Junior 3", null },
                    { 59, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9169), 0, null, "Student 59 in Junior 3", null },
                    { 60, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9169), 0, null, "Student 60 in Junior 3", null },
                    { 61, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9170), 0, null, "Student 61 in Junior 3", null },
                    { 62, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9171), 0, null, "Student 62 in Junior 3", null },
                    { 63, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9172), 0, null, "Student 63 in Junior 3", null },
                    { 64, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9173), 0, null, "Student 64 in Junior 3", null },
                    { 65, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9174), 0, null, "Student 65 in Junior 3", null },
                    { 66, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9174), 0, null, "Student 66 in Junior 3", null },
                    { 67, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9175), 0, null, "Student 67 in Junior 3", null },
                    { 68, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9176), 0, null, "Student 68 in Junior 3", null },
                    { 69, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9177), 0, null, "Student 69 in Junior 3", null },
                    { 70, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9178), 0, null, "Student 70 in Junior 3", null },
                    { 71, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9178), 0, null, "Student 71 in Junior 3", null },
                    { 72, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9179), 0, null, "Student 72 in Junior 3", null },
                    { 73, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9180), 0, null, "Student 73 in Junior 3", null },
                    { 74, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9181), 0, null, "Student 74 in Junior 3", null },
                    { 75, 0, null, 3, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9183), 0, null, "Student 75 in Junior 3", null },
                    { 76, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9184), 0, null, "Student 76 in Junior 4", null },
                    { 77, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9185), 0, null, "Student 77 in Junior 4", null },
                    { 78, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9186), 0, null, "Student 78 in Junior 4", null },
                    { 79, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9187), 0, null, "Student 79 in Junior 4", null },
                    { 80, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9188), 0, null, "Student 80 in Junior 4", null },
                    { 81, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9188), 0, null, "Student 81 in Junior 4", null },
                    { 82, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9190), 0, null, "Student 82 in Junior 4", null },
                    { 83, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9191), 0, null, "Student 83 in Junior 4", null },
                    { 84, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9191), 0, null, "Student 84 in Junior 4", null },
                    { 85, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9192), 0, null, "Student 85 in Junior 4", null },
                    { 86, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9193), 0, null, "Student 86 in Junior 4", null },
                    { 87, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9194), 0, null, "Student 87 in Junior 4", null },
                    { 88, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9195), 0, null, "Student 88 in Junior 4", null },
                    { 89, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9196), 0, null, "Student 89 in Junior 4", null },
                    { 90, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9197), 0, null, "Student 90 in Junior 4", null },
                    { 91, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9197), 0, null, "Student 91 in Junior 4", null },
                    { 92, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9198), 0, null, "Student 92 in Junior 4", null },
                    { 93, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9199), 0, null, "Student 93 in Junior 4", null },
                    { 94, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9200), 0, null, "Student 94 in Junior 4", null },
                    { 95, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9201), 0, null, "Student 95 in Junior 4", null },
                    { 96, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9202), 0, null, "Student 96 in Junior 4", null },
                    { 97, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9203), 0, null, "Student 97 in Junior 4", null },
                    { 98, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9203), 0, null, "Student 98 in Junior 4", null },
                    { 99, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9204), 0, null, "Student 99 in Junior 4", null },
                    { 100, 0, null, 4, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9205), 0, null, "Student 100 in Junior 4", null },
                    { 101, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9206), 0, null, "Student 101 in Wheeler 1", null },
                    { 102, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9207), 0, null, "Student 102 in Wheeler 1", null },
                    { 103, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9208), 0, null, "Student 103 in Wheeler 1", null },
                    { 104, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9209), 0, null, "Student 104 in Wheeler 1", null },
                    { 105, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9210), 0, null, "Student 105 in Wheeler 1", null },
                    { 106, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9211), 0, null, "Student 106 in Wheeler 1", null },
                    { 107, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9212), 0, null, "Student 107 in Wheeler 1", null },
                    { 108, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9213), 0, null, "Student 108 in Wheeler 1", null },
                    { 109, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9214), 0, null, "Student 109 in Wheeler 1", null },
                    { 110, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9214), 0, null, "Student 110 in Wheeler 1", null },
                    { 111, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9215), 0, null, "Student 111 in Wheeler 1", null },
                    { 112, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9216), 0, null, "Student 112 in Wheeler 1", null },
                    { 113, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9217), 0, null, "Student 113 in Wheeler 1", null },
                    { 114, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9218), 0, null, "Student 114 in Wheeler 1", null },
                    { 115, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9219), 0, null, "Student 115 in Wheeler 1", null },
                    { 116, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9220), 0, null, "Student 116 in Wheeler 1", null },
                    { 117, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9221), 0, null, "Student 117 in Wheeler 1", null },
                    { 118, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9221), 0, null, "Student 118 in Wheeler 1", null },
                    { 119, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9222), 0, null, "Student 119 in Wheeler 1", null },
                    { 120, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9223), 0, null, "Student 120 in Wheeler 1", null },
                    { 121, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9224), 0, null, "Student 121 in Wheeler 1", null },
                    { 122, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9225), 0, null, "Student 122 in Wheeler 1", null },
                    { 123, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9225), 0, null, "Student 123 in Wheeler 1", null },
                    { 124, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9226), 0, null, "Student 124 in Wheeler 1", null },
                    { 125, 0, null, 5, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9361), 0, null, "Student 125 in Wheeler 1", null },
                    { 126, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9362), 0, null, "Student 126 in Wheeler 2", null },
                    { 127, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9363), 0, null, "Student 127 in Wheeler 2", null },
                    { 128, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9364), 0, null, "Student 128 in Wheeler 2", null },
                    { 129, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9365), 0, null, "Student 129 in Wheeler 2", null },
                    { 130, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9366), 0, null, "Student 130 in Wheeler 2", null },
                    { 131, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9366), 0, null, "Student 131 in Wheeler 2", null },
                    { 132, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9367), 0, null, "Student 132 in Wheeler 2", null },
                    { 133, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9500), 0, null, "Student 133 in Wheeler 2", null },
                    { 134, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9501), 0, null, "Student 134 in Wheeler 2", null },
                    { 135, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9502), 0, null, "Student 135 in Wheeler 2", null },
                    { 136, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9503), 0, null, "Student 136 in Wheeler 2", null },
                    { 137, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9504), 0, null, "Student 137 in Wheeler 2", null },
                    { 138, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9505), 0, null, "Student 138 in Wheeler 2", null },
                    { 139, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9506), 0, null, "Student 139 in Wheeler 2", null },
                    { 140, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9506), 0, null, "Student 140 in Wheeler 2", null },
                    { 141, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9507), 0, null, "Student 141 in Wheeler 2", null },
                    { 142, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9508), 0, null, "Student 142 in Wheeler 2", null },
                    { 143, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9509), 0, null, "Student 143 in Wheeler 2", null },
                    { 144, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9510), 0, null, "Student 144 in Wheeler 2", null },
                    { 145, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9511), 0, null, "Student 145 in Wheeler 2", null },
                    { 146, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9511), 0, null, "Student 146 in Wheeler 2", null },
                    { 147, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9512), 0, null, "Student 147 in Wheeler 2", null },
                    { 148, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9513), 0, null, "Student 148 in Wheeler 2", null },
                    { 149, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9514), 0, null, "Student 149 in Wheeler 2", null },
                    { 150, 0, null, 6, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9515), 0, null, "Student 150 in Wheeler 2", null },
                    { 151, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9516), 0, null, "Student 151 in Wheeler 3", null },
                    { 152, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9516), 0, null, "Student 152 in Wheeler 3", null },
                    { 153, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9517), 0, null, "Student 153 in Wheeler 3", null },
                    { 154, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9518), 0, null, "Student 154 in Wheeler 3", null },
                    { 155, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9519), 0, null, "Student 155 in Wheeler 3", null },
                    { 156, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9520), 0, null, "Student 156 in Wheeler 3", null },
                    { 157, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9520), 0, null, "Student 157 in Wheeler 3", null },
                    { 158, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9521), 0, null, "Student 158 in Wheeler 3", null },
                    { 159, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9522), 0, null, "Student 159 in Wheeler 3", null },
                    { 160, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9523), 0, null, "Student 160 in Wheeler 3", null },
                    { 161, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9524), 0, null, "Student 161 in Wheeler 3", null },
                    { 162, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9529), 0, null, "Student 162 in Wheeler 3", null },
                    { 163, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9529), 0, null, "Student 163 in Wheeler 3", null },
                    { 164, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9530), 0, null, "Student 164 in Wheeler 3", null },
                    { 165, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9531), 0, null, "Student 165 in Wheeler 3", null },
                    { 166, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9532), 0, null, "Student 166 in Wheeler 3", null },
                    { 167, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9533), 0, null, "Student 167 in Wheeler 3", null },
                    { 168, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9534), 0, null, "Student 168 in Wheeler 3", null },
                    { 169, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9534), 0, null, "Student 169 in Wheeler 3", null },
                    { 170, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9535), 0, null, "Student 170 in Wheeler 3", null },
                    { 171, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9536), 0, null, "Student 171 in Wheeler 3", null },
                    { 172, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9537), 0, null, "Student 172 in Wheeler 3", null },
                    { 173, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9538), 0, null, "Student 173 in Wheeler 3", null },
                    { 174, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9539), 0, null, "Student 174 in Wheeler 3", null },
                    { 175, 0, null, 7, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9539), 0, null, "Student 175 in Wheeler 3", null },
                    { 176, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9540), 0, null, "Student 176 in Wheeler 4", null },
                    { 177, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9541), 0, null, "Student 177 in Wheeler 4", null },
                    { 178, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9542), 0, null, "Student 178 in Wheeler 4", null },
                    { 179, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9543), 0, null, "Student 179 in Wheeler 4", null },
                    { 180, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9543), 0, null, "Student 180 in Wheeler 4", null },
                    { 181, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9544), 0, null, "Student 181 in Wheeler 4", null },
                    { 182, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9545), 0, null, "Student 182 in Wheeler 4", null },
                    { 183, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9546), 0, null, "Student 183 in Wheeler 4", null },
                    { 184, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9547), 0, null, "Student 184 in Wheeler 4", null },
                    { 185, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9547), 0, null, "Student 185 in Wheeler 4", null },
                    { 186, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9548), 0, null, "Student 186 in Wheeler 4", null },
                    { 187, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9549), 0, null, "Student 187 in Wheeler 4", null },
                    { 188, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9550), 0, null, "Student 188 in Wheeler 4", null },
                    { 189, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9551), 0, null, "Student 189 in Wheeler 4", null },
                    { 190, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9552), 0, null, "Student 190 in Wheeler 4", null },
                    { 191, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9553), 0, null, "Student 191 in Wheeler 4", null },
                    { 192, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9553), 0, null, "Student 192 in Wheeler 4", null },
                    { 193, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9554), 0, null, "Student 193 in Wheeler 4", null },
                    { 194, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9555), 0, null, "Student 194 in Wheeler 4", null },
                    { 195, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9556), 0, null, "Student 195 in Wheeler 4", null },
                    { 196, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9557), 0, null, "Student 196 in Wheeler 4", null },
                    { 197, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9558), 0, null, "Student 197 in Wheeler 4", null },
                    { 198, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9558), 0, null, "Student 198 in Wheeler 4", null },
                    { 199, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9559), 0, null, "Student 199 in Wheeler 4", null },
                    { 200, 0, null, 8, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9560), 0, null, "Student 200 in Wheeler 4", null },
                    { 201, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9561), 0, null, "Student 201 in Senior 1", null },
                    { 202, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9562), 0, null, "Student 202 in Senior 1", null },
                    { 203, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9562), 0, null, "Student 203 in Senior 1", null },
                    { 204, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9563), 0, null, "Student 204 in Senior 1", null },
                    { 205, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9564), 0, null, "Student 205 in Senior 1", null },
                    { 206, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9565), 0, null, "Student 206 in Senior 1", null },
                    { 207, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9566), 0, null, "Student 207 in Senior 1", null },
                    { 208, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9567), 0, null, "Student 208 in Senior 1", null },
                    { 209, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9567), 0, null, "Student 209 in Senior 1", null },
                    { 210, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9568), 0, null, "Student 210 in Senior 1", null },
                    { 211, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9658), 0, null, "Student 211 in Senior 1", null },
                    { 212, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9659), 0, null, "Student 212 in Senior 1", null },
                    { 213, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9660), 0, null, "Student 213 in Senior 1", null },
                    { 214, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9661), 0, null, "Student 214 in Senior 1", null },
                    { 215, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9662), 0, null, "Student 215 in Senior 1", null },
                    { 216, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9663), 0, null, "Student 216 in Senior 1", null },
                    { 217, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9663), 0, null, "Student 217 in Senior 1", null },
                    { 218, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9664), 0, null, "Student 218 in Senior 1", null },
                    { 219, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9665), 0, null, "Student 219 in Senior 1", null },
                    { 220, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9667), 0, null, "Student 220 in Senior 1", null },
                    { 221, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9668), 0, null, "Student 221 in Senior 1", null },
                    { 222, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9668), 0, null, "Student 222 in Senior 1", null },
                    { 223, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9669), 0, null, "Student 223 in Senior 1", null },
                    { 224, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9670), 0, null, "Student 224 in Senior 1", null },
                    { 225, 0, null, 9, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9671), 0, null, "Student 225 in Senior 1", null },
                    { 226, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9672), 0, null, "Student 226 in Senior 2", null },
                    { 227, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9673), 0, null, "Student 227 in Senior 2", null },
                    { 228, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9673), 0, null, "Student 228 in Senior 2", null },
                    { 229, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9674), 0, null, "Student 229 in Senior 2", null },
                    { 230, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9675), 0, null, "Student 230 in Senior 2", null },
                    { 231, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9676), 0, null, "Student 231 in Senior 2", null },
                    { 232, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9677), 0, null, "Student 232 in Senior 2", null },
                    { 233, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9677), 0, null, "Student 233 in Senior 2", null },
                    { 234, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9678), 0, null, "Student 234 in Senior 2", null },
                    { 235, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9679), 0, null, "Student 235 in Senior 2", null },
                    { 236, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9680), 0, null, "Student 236 in Senior 2", null },
                    { 237, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9681), 0, null, "Student 237 in Senior 2", null },
                    { 238, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9681), 0, null, "Student 238 in Senior 2", null },
                    { 239, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9682), 0, null, "Student 239 in Senior 2", null },
                    { 240, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9683), 0, null, "Student 240 in Senior 2", null },
                    { 241, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9684), 0, null, "Student 241 in Senior 2", null },
                    { 242, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9685), 0, null, "Student 242 in Senior 2", null },
                    { 243, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9685), 0, null, "Student 243 in Senior 2", null },
                    { 244, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9686), 0, null, "Student 244 in Senior 2", null },
                    { 245, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9687), 0, null, "Student 245 in Senior 2", null },
                    { 246, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9688), 0, null, "Student 246 in Senior 2", null },
                    { 247, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9689), 0, null, "Student 247 in Senior 2", null },
                    { 248, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9690), 0, null, "Student 248 in Senior 2", null },
                    { 249, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9691), 0, null, "Student 249 in Senior 2", null },
                    { 250, 0, null, 10, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9691), 0, null, "Student 250 in Senior 2", null },
                    { 251, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9692), 0, null, "Student 251 in Senior 3", null },
                    { 252, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9693), 0, null, "Student 252 in Senior 3", null },
                    { 253, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9694), 0, null, "Student 253 in Senior 3", null },
                    { 254, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9695), 0, null, "Student 254 in Senior 3", null },
                    { 255, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9695), 0, null, "Student 255 in Senior 3", null },
                    { 256, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9696), 0, null, "Student 256 in Senior 3", null },
                    { 257, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9697), 0, null, "Student 257 in Senior 3", null },
                    { 258, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9698), 0, null, "Student 258 in Senior 3", null },
                    { 259, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9699), 0, null, "Student 259 in Senior 3", null },
                    { 260, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9699), 0, null, "Student 260 in Senior 3", null },
                    { 261, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9700), 0, null, "Student 261 in Senior 3", null },
                    { 262, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9701), 0, null, "Student 262 in Senior 3", null },
                    { 263, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9702), 0, null, "Student 263 in Senior 3", null },
                    { 264, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9703), 0, null, "Student 264 in Senior 3", null },
                    { 265, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9703), 0, null, "Student 265 in Senior 3", null },
                    { 266, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9704), 0, null, "Student 266 in Senior 3", null },
                    { 267, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9705), 0, null, "Student 267 in Senior 3", null },
                    { 268, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9706), 0, null, "Student 268 in Senior 3", null },
                    { 269, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9707), 0, null, "Student 269 in Senior 3", null },
                    { 270, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9708), 0, null, "Student 270 in Senior 3", null },
                    { 271, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9708), 0, null, "Student 271 in Senior 3", null },
                    { 272, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9709), 0, null, "Student 272 in Senior 3", null },
                    { 273, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9710), 0, null, "Student 273 in Senior 3", null },
                    { 274, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9711), 0, null, "Student 274 in Senior 3", null },
                    { 275, 0, null, 11, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9711), 0, null, "Student 275 in Senior 3", null },
                    { 276, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9712), 0, null, "Student 276 in Senior 4", null },
                    { 277, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9713), 0, null, "Student 277 in Senior 4", null },
                    { 278, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9715), 0, null, "Student 278 in Senior 4", null },
                    { 279, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9715), 0, null, "Student 279 in Senior 4", null },
                    { 280, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9716), 0, null, "Student 280 in Senior 4", null },
                    { 281, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9717), 0, null, "Student 281 in Senior 4", null },
                    { 282, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9718), 0, null, "Student 282 in Senior 4", null },
                    { 283, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9719), 0, null, "Student 283 in Senior 4", null },
                    { 284, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9719), 0, null, "Student 284 in Senior 4", null },
                    { 285, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9720), 0, null, "Student 285 in Senior 4", null },
                    { 286, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9721), 0, null, "Student 286 in Senior 4", null },
                    { 287, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9722), 0, null, "Student 287 in Senior 4", null },
                    { 288, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9722), 0, null, "Student 288 in Senior 4", null },
                    { 289, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9723), 0, null, "Student 289 in Senior 4", null },
                    { 290, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9771), 0, null, "Student 290 in Senior 4", null },
                    { 291, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9772), 0, null, "Student 291 in Senior 4", null },
                    { 292, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9773), 0, null, "Student 292 in Senior 4", null },
                    { 293, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9774), 0, null, "Student 293 in Senior 4", null },
                    { 294, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9775), 0, null, "Student 294 in Senior 4", null },
                    { 295, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9776), 0, null, "Student 295 in Senior 4", null },
                    { 296, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9776), 0, null, "Student 296 in Senior 4", null },
                    { 297, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9777), 0, null, "Student 297 in Senior 4", null },
                    { 298, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9778), 0, null, "Student 298 in Senior 4", null },
                    { 299, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9779), 0, null, "Student 299 in Senior 4", null },
                    { 300, 0, null, 12, null, new DateTime(2025, 7, 23, 14, 43, 1, 179, DateTimeKind.Utc).AddTicks(9780), 0, null, "Student 300 in Senior 4", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BehaviorNotes_AttendanceRecordId",
                table: "BehaviorNotes",
                column: "AttendanceRecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BehaviorNotes");

            migrationBuilder.DropTable(
                name: "AttendanceRecords");

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Wheeler 1");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Wheeler 2");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Wheeler 3");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Wheeler 4");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Senior 1");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Senior 2");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Senior 3");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Senior 4");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Junior 1");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Junior 2");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Junior 3");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Junior 4");

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Wheeler");

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Senior");

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Junior");

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClassId", "CreatedAt", "Name" },
                values: new object[] { 2, new DateTime(2025, 7, 22, 9, 26, 55, 768, DateTimeKind.Utc).AddTicks(5534), "Student 1" });

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClassId", "CreatedAt", "Name" },
                values: new object[] { 2, new DateTime(2025, 7, 22, 9, 26, 55, 768, DateTimeKind.Utc).AddTicks(5537), "Student 2" });

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClassId", "CreatedAt", "Name" },
                values: new object[] { 3, new DateTime(2025, 7, 22, 9, 26, 55, 768, DateTimeKind.Utc).AddTicks(5538), "Student 3" });

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClassId", "CreatedAt", "Name" },
                values: new object[] { 3, new DateTime(2025, 7, 22, 9, 26, 55, 768, DateTimeKind.Utc).AddTicks(5539), "Student 4" });

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClassId", "CreatedAt", "Name" },
                values: new object[] { 4, new DateTime(2025, 7, 22, 9, 26, 55, 768, DateTimeKind.Utc).AddTicks(5540), "Student 5" });

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClassId", "CreatedAt", "Name" },
                values: new object[] { 4, new DateTime(2025, 7, 22, 9, 26, 55, 768, DateTimeKind.Utc).AddTicks(5541), "Student 6" });
        }
    }
}
