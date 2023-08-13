using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Casgem_DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Employers_EmployerId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_JobSeekers_JobSeekerId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Employers_EmployerId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobAdvertisements_Employers_EmployerId",
                table: "JobAdvertisements");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_Employers_EmployerId",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_JobSeekers_JobSeekerId",
                table: "JobApplications");

            migrationBuilder.DropTable(
                name: "Degrees");

            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.DropTable(
                name: "JobSeekers");

            migrationBuilder.DropIndex(
                name: "IX_JobApplications_EmployerId",
                table: "JobApplications");

            migrationBuilder.DropIndex(
                name: "IX_Companies_EmployerId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EmployerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "JobSeekerId",
                table: "JobApplications",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_JobSeekerId",
                table: "JobApplications",
                newName: "IX_JobApplications_UserId");

            migrationBuilder.RenameColumn(
                name: "EmployerId",
                table: "JobAdvertisements",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobAdvertisements_EmployerId",
                table: "JobAdvertisements",
                newName: "IX_JobAdvertisements_UserId");

            migrationBuilder.RenameColumn(
                name: "JobSeekerId",
                table: "EducationInformations",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "DegreeId",
                table: "Companies",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "JobSeekerId",
                table: "AspNetUsers",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_JobSeekerId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_UserId");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurriculumVitaeId = table.Column<int>(type: "int", nullable: false),
                    EducationInformationId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    JobAdvertisementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_CurriculumVitaes_CurriculumVitaeId",
                        column: x => x.CurriculumVitaeId,
                        principalTable: "CurriculumVitaes",
                        principalColumn: "CurriculumVitaeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_EducationInformations_EducationInformationId",
                        column: x => x.EducationInformationId,
                        principalTable: "EducationInformations",
                        principalColumn: "EducationInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyUser",
                columns: table => new
                {
                    CompaniesCompanyId = table.Column<int>(type: "int", nullable: false),
                    UsersUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyUser", x => new { x.CompaniesCompanyId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_CompanyUser_Companies_CompaniesCompanyId",
                        column: x => x.CompaniesCompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyUser_Users_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUser_UsersUserId",
                table: "CompanyUser",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CurriculumVitaeId",
                table: "Users",
                column: "CurriculumVitaeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EducationInformationId",
                table: "Users",
                column: "EducationInformationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Users_UserId",
                table: "AspNetUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobAdvertisements_Users_UserId",
                table: "JobAdvertisements",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_Users_UserId",
                table: "JobApplications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Users_UserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_JobAdvertisements_Users_UserId",
                table: "JobAdvertisements");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_Users_UserId",
                table: "JobApplications");

            migrationBuilder.DropTable(
                name: "CompanyUser");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "JobApplications",
                newName: "JobSeekerId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_UserId",
                table: "JobApplications",
                newName: "IX_JobApplications_JobSeekerId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "JobAdvertisements",
                newName: "EmployerId");

            migrationBuilder.RenameIndex(
                name: "IX_JobAdvertisements_UserId",
                table: "JobAdvertisements",
                newName: "IX_JobAdvertisements_EmployerId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "EducationInformations",
                newName: "JobSeekerId");

            migrationBuilder.RenameColumn(
                name: "User",
                table: "Companies",
                newName: "DegreeId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AspNetUsers",
                newName: "JobSeekerId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_UserId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_JobSeekerId");

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "JobApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    EmployerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployerJobAdvertisementSearchHistoryId = table.Column<int>(type: "int", nullable: false),
                    JobAdvertisementId = table.Column<int>(type: "int", nullable: false),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePhoto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.EmployerId);
                });

            migrationBuilder.CreateTable(
                name: "JobSeekers",
                columns: table => new
                {
                    JobSeekerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurriculumVitaeId = table.Column<int>(type: "int", nullable: false),
                    EducationInformationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekers", x => x.JobSeekerId);
                    table.ForeignKey(
                        name: "FK_JobSeekers_CurriculumVitaes_CurriculumVitaeId",
                        column: x => x.CurriculumVitaeId,
                        principalTable: "CurriculumVitaes",
                        principalColumn: "CurriculumVitaeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobSeekers_EducationInformations_EducationInformationId",
                        column: x => x.EducationInformationId,
                        principalTable: "EducationInformations",
                        principalColumn: "EducationInformationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Degrees",
                columns: table => new
                {
                    DegreeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployerId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    JobSeekerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degrees", x => x.DegreeId);
                    table.ForeignKey(
                        name: "FK_Degrees_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_Degrees_Employers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employers",
                        principalColumn: "EmployerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Degrees_JobSeekers_JobSeekerId",
                        column: x => x.JobSeekerId,
                        principalTable: "JobSeekers",
                        principalColumn: "JobSeekerId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_EmployerId",
                table: "JobApplications",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_EmployerId",
                table: "Companies",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmployerId",
                table: "AspNetUsers",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Degrees_CompanyId",
                table: "Degrees",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Degrees_EmployerId",
                table: "Degrees",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Degrees_JobSeekerId",
                table: "Degrees",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekers_CurriculumVitaeId",
                table: "JobSeekers",
                column: "CurriculumVitaeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekers_EducationInformationId",
                table: "JobSeekers",
                column: "EducationInformationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Employers_EmployerId",
                table: "AspNetUsers",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "EmployerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_JobSeekers_JobSeekerId",
                table: "AspNetUsers",
                column: "JobSeekerId",
                principalTable: "JobSeekers",
                principalColumn: "JobSeekerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Employers_EmployerId",
                table: "Companies",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "EmployerId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobAdvertisements_Employers_EmployerId",
                table: "JobAdvertisements",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "EmployerId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_Employers_EmployerId",
                table: "JobApplications",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "EmployerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_JobSeekers_JobSeekerId",
                table: "JobApplications",
                column: "JobSeekerId",
                principalTable: "JobSeekers",
                principalColumn: "JobSeekerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
