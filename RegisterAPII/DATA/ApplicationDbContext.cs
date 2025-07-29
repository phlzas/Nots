using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using RegisterAPII.Models;

namespace RegisterAPII.DATA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.ConfigureWarnings(static warnings =>
        //        warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        //}

        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<LoginAccount> LoginAccounts { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<SubordinateTicket> subordinateTickets { get; set; }
        public DbSet<StudentProfile> StudentProfiles { get; set; }
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
        public DbSet<BehaviorNote> BehaviorNotes { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<NotificationCrud> NotificationCruds { get; set; }

        public DbSet<Report> Reports { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<AbsenceRecord> AbsenceRecords { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // for reports
            modelBuilder.Entity<Report>().HasData(
            new Report
            {
                Id = 1, // You MUST provide the primary key
                Date = new DateTime(2024, 3, 15),
                StudentName = "Ali Hassan",
                Description = "Student showed excellent participation in the group project but needs to focus more on individual assignments.",
                SpecialistSignature = "Dr. Mona Fikry",
                Status = "Accepted" // Use the exact string values
            },
            new Report
            {
                Id = 2,
                Date = new DateTime(2024, 3, 16),
                StudentName = "Nour Tarek",
                Description = "Nour has shown significant improvement in her problem-solving skills this week.",
                SpecialistSignature = "Eng. Sherif Hamdy",
                Status = "Pending"
            },
            new Report
            {
                Id = 3,
                Date = new DateTime(2024, 3, 17),
                StudentName = "Laila Mostafa",
                Description = "Laila was disruptive during the session and did not complete the assigned task. Recommend a follow-up.",
                SpecialistSignature = "Mr. Mohamed Abdelmged",
                Status = "Declined"
            }
        );

            // --- Seeding Roles ---
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, Name = "SuperAdmin" },
                new Role { RoleId = 2, Name = "Admin" },
                new Role { RoleId = 3, Name = "Student" },
                new Role { RoleId = 4, Name = "Specialist" },
                new Role { RoleId = 5, Name = "It" },
                new Role { RoleId = 6, Name = "Teacher" },
                new Role { RoleId = 7, Name = "Engineer" },
                new Role { RoleId = 8, Name = "Parent" }
            );

            modelBuilder.Entity<StudentProfile>()
                .Property(e => e.GoodNotesJson)
                .HasDefaultValue("[]");

            modelBuilder.Entity<StudentProfile>()
                .Property(e => e.BadNotesJson)
                .HasDefaultValue("[]");

            modelBuilder.Entity<StudentProfile>()
                .Property(e => e.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            //modelBuilder.Entity<AttendanceRecord>()
            //.HasMany(a => a.Notes)
            //.WithOne(n => n.AttendanceRecord)
            //.HasForeignKey(n => n.AttendanceRecordId);


            // --- Configure one-to-one relationship between Accounts and LoginAccount ---
            modelBuilder.Entity<Accounts>()
                .HasOne(a => a.LoginAccount)
                .WithOne(la => la.Accounts)
                .HasForeignKey<Accounts>(a => a.LoginId);


            modelBuilder.Entity<TicketType>().HasData(
                new TicketType { Id = 5, Name = "Late", OrderNo = 10, BusinessEntity = "Behaviour" },
                new TicketType { Id = 7, Name = "Eating", OrderNo = 30, BusinessEntity = "Behaviour" },
                new TicketType { Id = 10, Name = "SideTalks", OrderNo = 20, BusinessEntity = "Behaviour" },
                new TicketType { Id = 12, Name = "Absence", OrderNo = 10, BusinessEntity = "Absence" }
            );

            modelBuilder.Entity<Note>().HasData(
                new Note {Id = 1 , Name = "Side Talks" },
                new Note { Id = 2, Name = "Eating" },
                new Note { Id = 3, Name = "Late" }
                );

            modelBuilder.Entity<NotificationCrud>().HasData(
                new NotificationCrud { Id = 1, Title = "Notification 1", Descreption = "Description 1", Role = "Role 1", Date = new DateTime(2024, 1, 1), IsRidden = false }
            );


            modelBuilder.Entity<Grade>().HasData(
         new Grade { Id = 1, Name = "Junior" },
         new Grade { Id = 2, Name = "Wheeler" },
         new Grade { Id = 3, Name = "Senior" }
     );

            // Seed Classes
            modelBuilder.Entity<ClassRoom>().HasData(
                new ClassRoom { Id = 1, Name = "Junior 1", GradeId = 1 },
                new ClassRoom { Id = 2, Name = "Junior 2", GradeId = 1 },
                new ClassRoom { Id = 3, Name = "Junior 3", GradeId = 1 },
                new ClassRoom { Id = 4, Name = "Junior 4", GradeId = 1 },
                new ClassRoom { Id = 5, Name = "Wheeler 1", GradeId = 2 },
                new ClassRoom { Id = 6, Name = "Wheeler 2", GradeId = 2 },
                new ClassRoom { Id = 7, Name = "Wheeler 3", GradeId = 2 },
                new ClassRoom { Id = 8, Name = "Wheeler 4", GradeId = 2 },
                new ClassRoom { Id = 9, Name = "Senior 1", GradeId = 3 },
                new ClassRoom { Id = 10, Name = "Senior 2", GradeId = 3 },
                new ClassRoom { Id = 11, Name = "Senior 3", GradeId = 3 },
                new ClassRoom { Id = 12, Name = "Senior 4", GradeId = 3 }

            );

            // Seed Sessions
            modelBuilder.Entity<Session>().HasData(
                new Session { Id = 1, sessionNo = 1, ClassId = 1 },
                new Session { Id = 2, sessionNo = 2, ClassId = 2 },
                new Session { Id = 3, sessionNo = 3, ClassId = 3 },
                new Session { Id = 4, sessionNo = 4, ClassId = 4 },
                new Session { Id = 5, sessionNo = 5, ClassId = 5 },
                new Session { Id = 6, sessionNo = 6, ClassId = 6 },
                new Session { Id = 7, sessionNo = 7, ClassId = 7 },
                new Session { Id = 8, sessionNo = 8, ClassId = 8 }
            );

            // Seed Students
            modelBuilder.Entity<StudentProfile>().HasData(
         new StudentProfile { Id = 1, Name = "Student 1 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 2, Name = "Student 2 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 3, Name = "Student 3 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 4, Name = "Student 4 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 5, Name = "Student 5 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 6, Name = "Student 6 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 7, Name = "Student 7 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 8, Name = "Student 8 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 9, Name = "Student 9 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 10, Name = "Student 10 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 11, Name = "Student 11 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 12, Name = "Student 12 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 13, Name = "Student 13 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 14, Name = "Student 14 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 15, Name = "Student 15 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 16, Name = "Student 16 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 17, Name = "Student 17 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 18, Name = "Student 18 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 19, Name = "Student 19 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 20, Name = "Student 20 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 21, Name = "Student 21 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 22, Name = "Student 22 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 23, Name = "Student 23 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 24, Name = "Student 24 in Junior 1", ClassId = 1 },
         new StudentProfile { Id = 25, Name = "Student 25 in Junior 1", ClassId = 1 },

         new StudentProfile { Id = 26, Name = "Student 26 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 27, Name = "Student 27 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 28, Name = "Student 28 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 29, Name = "Student 29 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 30, Name = "Student 30 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 31, Name = "Student 31 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 32, Name = "Student 32 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 33, Name = "Student 33 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 34, Name = "Student 34 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 35, Name = "Student 35 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 36, Name = "Student 36 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 37, Name = "Student 37 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 38, Name = "Student 38 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 39, Name = "Student 39 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 40, Name = "Student 40 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 41, Name = "Student 41 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 42, Name = "Student 42 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 43, Name = "Student 43 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 44, Name = "Student 44 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 45, Name = "Student 45 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 46, Name = "Student 46 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 47, Name = "Student 47 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 48, Name = "Student 48 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 49, Name = "Student 49 in Junior 2", ClassId = 2 },
         new StudentProfile { Id = 50, Name = "Student 50 in Junior 2", ClassId = 2 },

         new StudentProfile { Id = 51, Name = "Student 51 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 52, Name = "Student 52 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 53, Name = "Student 53 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 54, Name = "Student 54 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 55, Name = "Student 55 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 56, Name = "Student 56 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 57, Name = "Student 57 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 58, Name = "Student 58 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 59, Name = "Student 59 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 60, Name = "Student 60 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 61, Name = "Student 61 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 62, Name = "Student 62 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 63, Name = "Student 63 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 64, Name = "Student 64 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 65, Name = "Student 65 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 66, Name = "Student 66 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 67, Name = "Student 67 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 68, Name = "Student 68 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 69, Name = "Student 69 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 70, Name = "Student 70 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 71, Name = "Student 71 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 72, Name = "Student 72 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 73, Name = "Student 73 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 74, Name = "Student 74 in Junior 3", ClassId = 3 },
         new StudentProfile { Id = 75, Name = "Student 75 in Junior 3", ClassId = 3 },

         new StudentProfile { Id = 76, Name = "Student 76 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 77, Name = "Student 77 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 78, Name = "Student 78 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 79, Name = "Student 79 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 80, Name = "Student 80 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 81, Name = "Student 81 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 82, Name = "Student 82 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 83, Name = "Student 83 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 84, Name = "Student 84 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 85, Name = "Student 85 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 86, Name = "Student 86 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 87, Name = "Student 87 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 88, Name = "Student 88 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 89, Name = "Student 89 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 90, Name = "Student 90 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 91, Name = "Student 91 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 92, Name = "Student 92 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 93, Name = "Student 93 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 94, Name = "Student 94 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 95, Name = "Student 95 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 96, Name = "Student 96 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 97, Name = "Student 97 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 98, Name = "Student 98 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 99, Name = "Student 99 in Junior 4", ClassId = 4 },
         new StudentProfile { Id = 100, Name = "Student 100 in Junior 4", ClassId = 4 },

         new StudentProfile { Id = 101, Name = "Student 101 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 102, Name = "Student 102 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 103, Name = "Student 103 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 104, Name = "Student 104 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 105, Name = "Student 105 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 106, Name = "Student 106 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 107, Name = "Student 107 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 108, Name = "Student 108 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 109, Name = "Student 109 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 110, Name = "Student 110 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 111, Name = "Student 111 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 112, Name = "Student 112 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 113, Name = "Student 113 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 114, Name = "Student 114 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 115, Name = "Student 115 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 116, Name = "Student 116 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 117, Name = "Student 117 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 118, Name = "Student 118 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 119, Name = "Student 119 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 120, Name = "Student 120 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 121, Name = "Student 121 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 122, Name = "Student 122 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 123, Name = "Student 123 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 124, Name = "Student 124 in Wheeler 1", ClassId = 5 },
         new StudentProfile { Id = 125, Name = "Student 125 in Wheeler 1", ClassId = 5 },

         new StudentProfile { Id = 126, Name = "Student 126 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 127, Name = "Student 127 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 128, Name = "Student 128 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 129, Name = "Student 129 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 130, Name = "Student 130 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 131, Name = "Student 131 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 132, Name = "Student 132 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 133, Name = "Student 133 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 134, Name = "Student 134 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 135, Name = "Student 135 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 136, Name = "Student 136 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 137, Name = "Student 137 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 138, Name = "Student 138 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 139, Name = "Student 139 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 140, Name = "Student 140 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 141, Name = "Student 141 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 142, Name = "Student 142 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 143, Name = "Student 143 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 144, Name = "Student 144 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 145, Name = "Student 145 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 146, Name = "Student 146 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 147, Name = "Student 147 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 148, Name = "Student 148 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 149, Name = "Student 149 in Wheeler 2", ClassId = 6 },
         new StudentProfile { Id = 150, Name = "Student 150 in Wheeler 2", ClassId = 6 },

         new StudentProfile { Id = 151, Name = "Student 151 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 152, Name = "Student 152 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 153, Name = "Student 153 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 154, Name = "Student 154 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 155, Name = "Student 155 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 156, Name = "Student 156 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 157, Name = "Student 157 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 158, Name = "Student 158 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 159, Name = "Student 159 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 160, Name = "Student 160 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 161, Name = "Student 161 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 162, Name = "Student 162 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 163, Name = "Student 163 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 164, Name = "Student 164 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 165, Name = "Student 165 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 166, Name = "Student 166 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 167, Name = "Student 167 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 168, Name = "Student 168 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 169, Name = "Student 169 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 170, Name = "Student 170 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 171, Name = "Student 171 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 172, Name = "Student 172 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 173, Name = "Student 173 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 174, Name = "Student 174 in Wheeler 3", ClassId = 7 },
         new StudentProfile { Id = 175, Name = "Student 175 in Wheeler 3", ClassId = 7 },

         new StudentProfile { Id = 176, Name = "Student 176 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 177, Name = "Student 177 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 178, Name = "Student 178 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 179, Name = "Student 179 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 180, Name = "Student 180 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 181, Name = "Student 181 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 182, Name = "Student 182 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 183, Name = "Student 183 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 184, Name = "Student 184 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 185, Name = "Student 185 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 186, Name = "Student 186 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 187, Name = "Student 187 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 188, Name = "Student 188 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 189, Name = "Student 189 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 190, Name = "Student 190 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 191, Name = "Student 191 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 192, Name = "Student 192 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 193, Name = "Student 193 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 194, Name = "Student 194 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 195, Name = "Student 195 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 196, Name = "Student 196 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 197, Name = "Student 197 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 198, Name = "Student 198 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 199, Name = "Student 199 in Wheeler 4", ClassId = 8 },
         new StudentProfile { Id = 200, Name = "Student 200 in Wheeler 4", ClassId = 8 },

         new StudentProfile { Id = 201, Name = "Student 201 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 202, Name = "Student 202 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 203, Name = "Student 203 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 204, Name = "Student 204 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 205, Name = "Student 205 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 206, Name = "Student 206 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 207, Name = "Student 207 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 208, Name = "Student 208 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 209, Name = "Student 209 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 210, Name = "Student 210 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 211, Name = "Student 211 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 212, Name = "Student 212 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 213, Name = "Student 213 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 214, Name = "Student 214 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 215, Name = "Student 215 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 216, Name = "Student 216 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 217, Name = "Student 217 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 218, Name = "Student 218 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 219, Name = "Student 219 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 220, Name = "Student 220 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 221, Name = "Student 221 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 222, Name = "Student 222 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 223, Name = "Student 223 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 224, Name = "Student 224 in Senior 1", ClassId = 9 },
         new StudentProfile { Id = 225, Name = "Student 225 in Senior 1", ClassId = 9 },

         new StudentProfile { Id = 226, Name = "Student 226 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 227, Name = "Student 227 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 228, Name = "Student 228 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 229, Name = "Student 229 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 230, Name = "Student 230 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 231, Name = "Student 231 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 232, Name = "Student 232 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 233, Name = "Student 233 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 234, Name = "Student 234 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 235, Name = "Student 235 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 236, Name = "Student 236 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 237, Name = "Student 237 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 238, Name = "Student 238 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 239, Name = "Student 239 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 240, Name = "Student 240 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 241, Name = "Student 241 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 242, Name = "Student 242 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 243, Name = "Student 243 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 244, Name = "Student 244 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 245, Name = "Student 245 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 246, Name = "Student 246 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 247, Name = "Student 247 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 248, Name = "Student 248 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 249, Name = "Student 249 in Senior 2", ClassId = 10 },
         new StudentProfile { Id = 250, Name = "Student 250 in Senior 2", ClassId = 10 },

         new StudentProfile { Id = 251, Name = "Student 251 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 252, Name = "Student 252 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 253, Name = "Student 253 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 254, Name = "Student 254 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 255, Name = "Student 255 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 256, Name = "Student 256 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 257, Name = "Student 257 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 258, Name = "Student 258 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 259, Name = "Student 259 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 260, Name = "Student 260 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 261, Name = "Student 261 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 262, Name = "Student 262 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 263, Name = "Student 263 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 264, Name = "Student 264 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 265, Name = "Student 265 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 266, Name = "Student 266 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 267, Name = "Student 267 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 268, Name = "Student 268 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 269, Name = "Student 269 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 270, Name = "Student 270 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 271, Name = "Student 271 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 272, Name = "Student 272 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 273, Name = "Student 273 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 274, Name = "Student 274 in Senior 3", ClassId = 11 },
         new StudentProfile { Id = 275, Name = "Student 275 in Senior 3", ClassId = 11 },

         new StudentProfile { Id = 276, Name = "Student 276 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 277, Name = "Student 277 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 278, Name = "Student 278 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 279, Name = "Student 279 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 280, Name = "Student 280 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 281, Name = "Student 281 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 282, Name = "Student 282 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 283, Name = "Student 283 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 284, Name = "Student 284 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 285, Name = "Student 285 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 286, Name = "Student 286 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 287, Name = "Student 287 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 288, Name = "Student 288 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 289, Name = "Student 289 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 290, Name = "Student 290 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 291, Name = "Student 291 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 292, Name = "Student 292 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 293, Name = "Student 293 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 294, Name = "Student 294 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 295, Name = "Student 295 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 296, Name = "Student 296 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 297, Name = "Student 297 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 298, Name = "Student 298 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 299, Name = "Student 299 in Senior 4", ClassId = 12 },
         new StudentProfile { Id = 300, Name = "Student 300 in Senior 4", ClassId = 12 }
     );

            modelBuilder.Entity<LoginAccount>().HasData(
                // --- Role 1 ---
                new LoginAccount { Id = 1, Email = "batolmagdy092@gmail.com", Password = "StrongPassword123", NationalID = "30101010000001", AccountId = 1 },
                new LoginAccount { Id = 2, Email = "user2.role1@example.com", Password = "StrongPassword123", NationalID = "30101010000002", AccountId = 2 },
                new LoginAccount { Id = 3, Email = "user3.role1@example.com", Password = "StrongPassword123", NationalID = "30101010000003", AccountId = 3 },
                new LoginAccount { Id = 4, Email = "user4.role1@example.com", Password = "StrongPassword123", NationalID = "30101010000004", AccountId = 4 },
                new LoginAccount { Id = 5, Email = "user5.role1@example.com", Password = "StrongPassword123", NationalID = "30101010000005", AccountId = 5 },
                // --- Role 2 ---
                new LoginAccount { Id = 6, Email = "user6.role2@example.com", Password = "StrongPassword123", NationalID = "30101010000006", AccountId = 6 },
                new LoginAccount { Id = 7, Email = "user7.role2@example.com", Password = "StrongPassword123", NationalID = "30101010000007", AccountId = 7 },
                new LoginAccount { Id = 8, Email = "user8.role2@example.com", Password = "StrongPassword123", NationalID = "30101010000008", AccountId = 8 },
                new LoginAccount { Id = 9, Email = "user9.role2@example.com", Password = "StrongPassword123", NationalID = "30101010000009", AccountId = 9 },
                new LoginAccount { Id = 10, Email = "user10.role2@example.com", Password = "StrongPassword123", NationalID = "30101010000010", AccountId = 10 },
                // --- Role 3 ---
                new LoginAccount { Id = 11, Email = "user11.role3@example.com", Password = "StrongPassword123", NationalID = "30101010000011", AccountId = 11 },
                new LoginAccount { Id = 12, Email = "user12.role3@example.com", Password = "StrongPassword123", NationalID = "30101010000012", AccountId = 12 },
                new LoginAccount { Id = 13, Email = "user13.role3@example.com", Password = "StrongPassword123", NationalID = "30101010000013", AccountId = 13 },
                new LoginAccount { Id = 14, Email = "user14.role3@example.com", Password = "StrongPassword123", NationalID = "30101010000014", AccountId = 14 },
                new LoginAccount { Id = 15, Email = "user15.role3@example.com", Password = "StrongPassword123", NationalID = "30101010000015", AccountId = 15 },
                // --- Role 4 ---
                new LoginAccount { Id = 16, Email = "user16.role4@example.com", Password = "StrongPassword123", NationalID = "30101010000016", AccountId = 16 },
                new LoginAccount { Id = 17, Email = "user17.role4@example.com", Password = "StrongPassword123", NationalID = "30101010000017", AccountId = 17 },
                new LoginAccount { Id = 18, Email = "user18.role4@example.com", Password = "StrongPassword123", NationalID = "30101010000018", AccountId = 18 },
                new LoginAccount { Id = 19, Email = "user19.role4@example.com", Password = "StrongPassword123", NationalID = "30101010000019", AccountId = 19 },
                new LoginAccount { Id = 20, Email = "user20.role4@example.com", Password = "StrongPassword123", NationalID = "30101010000020", AccountId = 20 },
                // --- Role 5 ---
                new LoginAccount { Id = 21, Email = "user21.role5@example.com", Password = "StrongPassword123", NationalID = "30101010000021", AccountId = 21 },
                new LoginAccount { Id = 22, Email = "user22.role5@example.com", Password = "StrongPassword123", NationalID = "30101010000022", AccountId = 22 },
                new LoginAccount { Id = 23, Email = "user23.role5@example.com", Password = "StrongPassword123", NationalID = "30101010000023", AccountId = 23 },
                new LoginAccount { Id = 24, Email = "user24.role5@example.com", Password = "StrongPassword123", NationalID = "30101010000024", AccountId = 24 },
                new LoginAccount { Id = 25, Email = "user25.role5@example.com", Password = "StrongPassword123", NationalID = "30101010000025", AccountId = 25 },
                // --- Role 6 ---
                new LoginAccount { Id = 26, Email = "user26.role6@example.com", Password = "StrongPassword123", NationalID = "30101010000026", AccountId = 26 },
                new LoginAccount { Id = 27, Email = "user27.role6@example.com", Password = "StrongPassword123", NationalID = "30101010000027", AccountId = 27 },
                new LoginAccount { Id = 28, Email = "user28.role6@example.com", Password = "StrongPassword123", NationalID = "30101010000028", AccountId = 28 },
                new LoginAccount { Id = 29, Email = "user29.role6@example.com", Password = "StrongPassword123", NationalID = "30101010000029", AccountId = 29 },
                new LoginAccount { Id = 30, Email = "user30.role6@example.com", Password = "StrongPassword123", NationalID = "30101010000030", AccountId = 30 },
                // --- Role 7 ---
                new LoginAccount { Id = 31, Email = "user31.role7@example.com", Password = "StrongPassword123", NationalID = "30101010000031", AccountId = 31 },
                new LoginAccount { Id = 32, Email = "user32.role7@example.com", Password = "StrongPassword123", NationalID = "30101010000032", AccountId = 32 },
                new LoginAccount { Id = 33, Email = "user33.role7@example.com", Password = "StrongPassword123", NationalID = "30101010000033", AccountId = 33 },
                new LoginAccount { Id = 34, Email = "user34.role7@example.com", Password = "StrongPassword123", NationalID = "30101010000034", AccountId = 34 },
                new LoginAccount { Id = 35, Email = "user35.role7@example.com", Password = "StrongPassword123", NationalID = "30101010000035", AccountId = 35 }
            );

            // --- Seed all 35 Accounts in a SINGLE HasData call with empty passwords ---
            modelBuilder.Entity<Accounts>().HasData(
                // --- Role 1 ---
                new Accounts { Id = 1, FullName = "User 1 (Role 1)", Email = "batolmagdy092@gmail.com", NationalID = "30101010000001", PasswordHash = "", RoleId = 1, LoginId = 1, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 2, FullName = "User 2 (Role 1)", Email = "user2.role1@example.com", NationalID = "30101010000002", PasswordHash = "", RoleId = 1, LoginId = 2, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 3, FullName = "User 3 (Role 1)", Email = "user3.role1@example.com", NationalID = "30101010000003", PasswordHash = "", RoleId = 1, LoginId = 3, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 4, FullName = "User 4 (Role 1)", Email = "user4.role1@example.com", NationalID = "30101010000004", PasswordHash = "", RoleId = 1, LoginId = 4, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 5, FullName = "User 5 (Role 1)", Email = "user5.role1@example.com", NationalID = "30101010000005", PasswordHash = "", RoleId = 1, LoginId = 5, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                // --- Role 2 ---
                new Accounts { Id = 6, FullName = "User 6 (Role 2)", Email = "user6.role2@example.com", NationalID = "30101010000006", PasswordHash = "", RoleId = 2, LoginId = 6, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 7, FullName = "User 7 (Role 2)", Email = "user7.role2@example.com", NationalID = "30101010000007", PasswordHash = "", RoleId = 2, LoginId = 7, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 8, FullName = "User 8 (Role 2)", Email = "user8.role2@example.com", NationalID = "30101010000008", PasswordHash = "", RoleId = 2, LoginId = 8, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 9, FullName = "User 9 (Role 2)", Email = "user9.role2@example.com", NationalID = "30101010000009", PasswordHash = "", RoleId = 2, LoginId = 9, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 10, FullName = "User 10 (Role 2)", Email = "user10.role2@example.com", NationalID = "30101010000010", PasswordHash = "", RoleId = 2, LoginId = 10, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                // --- Role 3 ---
                new Accounts { Id = 11, FullName = "User 11 (Role 3)", Email = "user11.role3@example.com", NationalID = "30101010000011", PasswordHash = "", RoleId = 3, LoginId = 11, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 12, FullName = "User 12 (Role 3)", Email = "user12.role3@example.com", NationalID = "30101010000012", PasswordHash = "", RoleId = 3, LoginId = 12, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 13, FullName = "User 13 (Role 3)", Email = "user13.role3@example.com", NationalID = "30101010000013", PasswordHash = "", RoleId = 3, LoginId = 13, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 14, FullName = "User 14 (Role 3)", Email = "user14.role3@example.com", NationalID = "30101010000014", PasswordHash = "", RoleId = 3, LoginId = 14, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 15, FullName = "User 15 (Role 3)", Email = "user15.role3@example.com", NationalID = "30101010000015", PasswordHash = "", RoleId = 3, LoginId = 15, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                // --- Role 4 ---
                new Accounts { Id = 16, FullName = "User 16 (Role 4)", Email = "user16.role4@example.com", NationalID = "30101010000016", PasswordHash = "", RoleId = 4, LoginId = 16, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 17, FullName = "User 17 (Role 4)", Email = "user17.role4@example.com", NationalID = "30101010000017", PasswordHash = "", RoleId = 4, LoginId = 17, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 18, FullName = "User 18 (Role 4)", Email = "user18.role4@example.com", NationalID = "30101010000018", PasswordHash = "", RoleId = 4, LoginId = 18, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 19, FullName = "User 19 (Role 4)", Email = "user19.role4@example.com", NationalID = "30101010000019", PasswordHash = "", RoleId = 4, LoginId = 19, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 20, FullName = "User 20 (Role 4)", Email = "user20.role4@example.com", NationalID = "30101010000020", PasswordHash = "", RoleId = 4, LoginId = 20, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                // --- Role 5 ---
                new Accounts { Id = 21, FullName = "User 21 (Role 5)", Email = "user21.role5@example.com", NationalID = "30101010000021", PasswordHash = "", RoleId = 5, LoginId = 21, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 22, FullName = "User 22 (Role 5)", Email = "user22.role5@example.com", NationalID = "30101010000022", PasswordHash = "", RoleId = 5, LoginId = 22, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 23, FullName = "User 23 (Role 5)", Email = "user23.role5@example.com", NationalID = "30101010000023", PasswordHash = "", RoleId = 5, LoginId = 23, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 24, FullName = "User 24 (Role 5)", Email = "user24.role5@example.com", NationalID = "30101010000024", PasswordHash = "", RoleId = 5, LoginId = 24, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 25, FullName = "User 25 (Role 5)", Email = "user25.role5@example.com", NationalID = "30101010000025", PasswordHash = "", RoleId = 5, LoginId = 25, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                // --- Role 6 ---
                new Accounts { Id = 26, FullName = "User 26 (Role 6)", Email = "user26.role6@example.com", NationalID = "30101010000026", PasswordHash = "", RoleId = 6, LoginId = 26, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 27, FullName = "User 27 (Role 6)", Email = "user27.role6@example.com", NationalID = "30101010000027", PasswordHash = "", RoleId = 6, LoginId = 27, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 28, FullName = "User 28 (Role 6)", Email = "user28.role6@example.com", NationalID = "30101010000028", PasswordHash = "", RoleId = 6, LoginId = 28, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 29, FullName = "User 29 (Role 6)", Email = "user29.role6@example.com", NationalID = "30101010000029", PasswordHash = "", RoleId = 6, LoginId = 29, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 30, FullName = "User 30 (Role 6)", Email = "user30.role6@example.com", NationalID = "30101010000030", PasswordHash = "", RoleId = 6, LoginId = 30, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                // --- Role 7 ---
                new Accounts { Id = 31, FullName = "User 31 (Role 7)", Email = "user31.role7@example.com", NationalID = "30101010000031", PasswordHash = "", RoleId = 7, LoginId = 31, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 32, FullName = "User 32 (Role 7)", Email = "user32.role7@example.com", NationalID = "30101010000032", PasswordHash = "", RoleId = 7, LoginId = 32, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 33, FullName = "User 33 (Role 7)", Email = "user33.role7@example.com", NationalID = "30101010000033", PasswordHash = "", RoleId = 7, LoginId = 33, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 34, FullName = "User 34 (Role 7)", Email = "user34.role7@example.com", NationalID = "30101010000034", PasswordHash = "", RoleId = 7, LoginId = 34, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) },
                new Accounts { Id = 35, FullName = "User 35 (Role 7)", Email = "user35.role7@example.com", NationalID = "30101010000035", PasswordHash = "", RoleId = 7, LoginId = 35, IsActive = true, CreatedAt = new DateTime(2025, 07, 16) }
            );

            // =================================================================
            // END OF SEED DATA
            // =================================================================
        }
    }
}