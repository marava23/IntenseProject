using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intense.EFDataAccess.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateSkills",
                columns: table => new
                {
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateSkills", x => new { x.CandidateId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_CandidateSkills_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BirthDay", "CreatedAt", "DeletedAt", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1987, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "amber.leuschke@predovic.us", "Casimer", "Ward", "229-964-2801 x72460", null },
                    { 8, new DateTime(1991, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "deanna_halvorson@hettingerschroeder.uk", "Tara", "Keeling", "384.905.3046", null },
                    { 7, new DateTime(1980, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "lila_kuphal@vandervort.name", "Lempi", "Ratke", "1-529-024-4782 x8618", null },
                    { 6, new DateTime(1999, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "nathanael@walter.com", "Lenora", "Nader", "1-189-101-6861 x51174", null },
                    { 9, new DateTime(1994, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "antonietta@vonrueden.name", "Francis", "Schoen", "422-531-3831", null },
                    { 4, new DateTime(1987, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "christina@raukunze.com", "Ralph", "Toy", "556.023.5643 x009", null },
                    { 3, new DateTime(1983, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "laurence_jerde@greenfelder.uk", "Maddison", "Labadie", "(849)543-9825", null },
                    { 2, new DateTime(1984, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "gertrude_vandervort@bodeklocko.co.uk", "Camron", "Gerhold", "1-425-819-0475", null },
                    { 5, new DateTime(1989, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "eleonore.gottlieb@wintheiser.biz", "Maverick", "Boehm", "399-081-1875 x59380", null }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "c", null },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "java", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "php", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "c#", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "html", null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "css", null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "javascript", null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "python", null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "c++", null }
                });

            migrationBuilder.InsertData(
                table: "CandidateSkills",
                columns: new[] { "CandidateId", "SkillId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 4, 1 },
                    { 2, 2 },
                    { 5, 2 },
                    { 1, 3 },
                    { 3, 3 },
                    { 7, 3 },
                    { 1, 4 },
                    { 4, 4 },
                    { 3, 4 },
                    { 5, 6 },
                    { 4, 7 },
                    { 7, 7 },
                    { 2, 8 },
                    { 2, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_Email",
                table: "Candidates",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateSkills_SkillId",
                table: "CandidateSkills",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateSkills");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
