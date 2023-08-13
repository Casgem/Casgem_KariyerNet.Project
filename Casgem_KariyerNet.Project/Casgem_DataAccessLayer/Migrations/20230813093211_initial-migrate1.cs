using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Casgem_DataAccessLayer.Migrations
{
    public partial class initialmigrate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUser_Companies_CompanyId",
                table: "CompanyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUser_WorkExperiences_WorkExperienceId",
                table: "CompanyUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyUser",
                table: "CompanyUser");

            migrationBuilder.DropIndex(
                name: "IX_CompanyUser_CompanyId",
                table: "CompanyUser");

            migrationBuilder.DropIndex(
                name: "IX_CompanyUser_WorkExperienceId",
                table: "CompanyUser");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CompanyUser");

            migrationBuilder.DropColumn(
                name: "WorkExperienceId",
                table: "CompanyUser");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "CompanyUser",
                newName: "CompaniesCompanyId");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyUser",
                table: "CompanyUser",
                columns: new[] { "CompaniesCompanyId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUser_Companies_CompaniesCompanyId",
                table: "CompanyUser",
                column: "CompaniesCompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUser_Companies_CompaniesCompanyId",
                table: "CompanyUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyUser",
                table: "CompanyUser");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "CompaniesCompanyId",
                table: "CompanyUser",
                newName: "CompanyId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CompanyUser",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "WorkExperienceId",
                table: "CompanyUser",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyUser",
                table: "CompanyUser",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUser_CompanyId",
                table: "CompanyUser",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUser_WorkExperienceId",
                table: "CompanyUser",
                column: "WorkExperienceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUser_Companies_CompanyId",
                table: "CompanyUser",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUser_WorkExperiences_WorkExperienceId",
                table: "CompanyUser",
                column: "WorkExperienceId",
                principalTable: "WorkExperiences",
                principalColumn: "WorkExperienceId");
        }
    }
}
