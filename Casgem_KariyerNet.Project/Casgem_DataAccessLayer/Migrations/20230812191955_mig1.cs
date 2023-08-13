using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Casgem_DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Degrees_Companies_CompanyId",
                table: "Degrees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employers_AspNetUsers_AppUserId",
                table: "Employers");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekers_AspNetUsers_AppUserId",
                table: "JobSeekers");

            migrationBuilder.DropTable(
                name: "EmployerJobAdvertisementSearchHistories");

            migrationBuilder.DropTable(
                name: "JobSeekerJobAdvertisementSearchHistories");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekers_AppUserId",
                table: "JobSeekers");

            migrationBuilder.DropIndex(
                name: "IX_Employers_AppUserId",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "DegreeId",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "JobApplicationId",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "JobSeekerJobAdvertisementSearchHistoryId",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "DegreeId",
                table: "Employers");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Degrees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobSeekerId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmployerId",
                table: "AspNetUsers",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_JobSeekerId",
                table: "AspNetUsers",
                column: "JobSeekerId");

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
                name: "FK_Degrees_Companies_CompanyId",
                table: "Degrees",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Employers_EmployerId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_JobSeekers_JobSeekerId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Degrees_Companies_CompanyId",
                table: "Degrees");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EmployerId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_JobSeekerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "JobSeekerId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "JobSeekers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DegreeId",
                table: "JobSeekers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobApplicationId",
                table: "JobSeekers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobSeekerJobAdvertisementSearchHistoryId",
                table: "JobSeekers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Employers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DegreeId",
                table: "Employers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Degrees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "EmployerJobAdvertisementSearchHistories",
                columns: table => new
                {
                    EmployerJobAdvertisementSearchHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployerId = table.Column<int>(type: "int", nullable: false),
                    Word = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployerJobAdvertisementSearchHistories", x => x.EmployerJobAdvertisementSearchHistoryId);
                    table.ForeignKey(
                        name: "FK_EmployerJobAdvertisementSearchHistories_Employers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employers",
                        principalColumn: "EmployerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerJobAdvertisementSearchHistories",
                columns: table => new
                {
                    JobSeekerJobAdvertisementSearchHistoryId = table.Column<int>(type: "int", nullable: false),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    Word = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerJobAdvertisementSearchHistories", x => x.JobSeekerJobAdvertisementSearchHistoryId);
                    table.ForeignKey(
                        name: "FK_JobSeekerJobAdvertisementSearchHistories_JobSeekers_JobSeekerJobAdvertisementSearchHistoryId",
                        column: x => x.JobSeekerJobAdvertisementSearchHistoryId,
                        principalTable: "JobSeekers",
                        principalColumn: "JobSeekerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekers_AppUserId",
                table: "JobSeekers",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employers_AppUserId",
                table: "Employers",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployerJobAdvertisementSearchHistories_EmployerId",
                table: "EmployerJobAdvertisementSearchHistories",
                column: "EmployerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Degrees_Companies_CompanyId",
                table: "Degrees",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employers_AspNetUsers_AppUserId",
                table: "Employers",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekers_AspNetUsers_AppUserId",
                table: "JobSeekers",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
