using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RegisterAPII.Migrations
{
    /// <inheritdoc />
    public partial class alllllllllllll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialistSignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Date", "Description", "SpecialistSignature", "Status", "StudentName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student showed excellent participation in the group project but needs to focus more on individual assignments.", "Dr. Mona Fikry", "Accepted", "Ali Hassan" },
                    { 2, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nour has shown significant improvement in her problem-solving skills this week.", "Eng. Sherif Hamdy", "Pending", "Nour Tarek" },
                    { 3, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laila was disruptive during the session and did not complete the assigned task. Recommend a follow-up.", "Mr. Mohamed Abdelmged", "Declined", "Laila Mostafa" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");

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
    }
}
