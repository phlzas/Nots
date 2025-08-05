using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RegisterAPII.Migrations
{
    /// <inheritdoc />
    public partial class AddStaffModelFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CheckInTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckInMethod = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId");
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "AccountId", "CheckInMethod", "CheckInTime", "CreatedAt", "Date", "Department", "EmployeeName", "RoleId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, "Fingerprint", new DateTime(2025, 8, 5, 7, 45, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6978), new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Mathematics", "Ahmed Hassan", 6, "Present", null },
                    { 2, null, "FaceID", new DateTime(2025, 8, 5, 7, 30, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6983), new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc), "English", "Fatima Al-Zahra", 6, "Present", null },
                    { 3, null, "Manual", new DateTime(2025, 8, 5, 8, 15, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(7018), new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Science", "Omar Mahmoud", 6, "Late", null },
                    { 4, null, "Fingerprint", new DateTime(2025, 8, 5, 8, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(7021), new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Administration", "Layla Ibrahim", 2, "Present", null },
                    { 5, null, "FaceID", new DateTime(2025, 8, 5, 7, 50, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(7025), new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc), "IT Support", "Khaled Nasser", 5, "Present", null },
                    { 6, null, "Fingerprint", new DateTime(2025, 8, 5, 6, 30, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(7029), new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Security", "Mohamed Ali", 7, "Present", null },
                    { 7, null, "N/A", null, new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(7032), new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Maintenance", "Youssef Karim", 7, "Absent", null },
                    { 8, null, "FaceID", new DateTime(2025, 8, 5, 7, 40, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(7035), new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Arabic", "Nadia Saleh", 6, "Present", null },
                    { 9, null, "Manual", new DateTime(2025, 8, 5, 8, 20, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(7039), new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Physical Education", "Hassan Fouad", 6, "Late", null },
                    { 10, null, "Fingerprint", new DateTime(2025, 8, 5, 7, 55, 0, 0, DateTimeKind.Utc), new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Art", "Maryam Othman", 6, "Present", null }
                });

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 5, 0, 4, 50, 551, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.CreateIndex(
                name: "IX_Staff_AccountId",
                table: "Staff",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_RoleId",
                table: "Staff",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "StudentProfiles",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 4, 11, 20, 55, 232, DateTimeKind.Utc).AddTicks(362));
        }
    }
}
