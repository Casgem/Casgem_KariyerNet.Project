using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Casgem_DataAccessLayer.Migrations
{
    public partial class mig9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUser_Companies_CompaniesCompanyId",
                table: "CompanyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUser_Users_UsersUserId",
                table: "CompanyUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyUser",
                table: "CompanyUser");

            migrationBuilder.DropColumn(
                name: "User",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "UsersUserId",
                table: "CompanyUser",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CompaniesCompanyId",
                table: "CompanyUser",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyUser_UsersUserId",
                table: "CompanyUser",
                newName: "IX_CompanyUser_UserId");

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

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Companies",
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

            migrationBuilder.CreateIndex(
                name: "IX_Companies_UserId",
                table: "Companies",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Users_UserId",
                table: "Companies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUser_Companies_CompanyId",
                table: "CompanyUser",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUser_Users_UserId",
                table: "CompanyUser",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUser_WorkExperiences_WorkExperienceId",
                table: "CompanyUser",
                column: "WorkExperienceId",
                principalTable: "WorkExperiences",
                principalColumn: "WorkExperienceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Users_UserId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUser_Companies_CompanyId",
                table: "CompanyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUser_Users_UserId",
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

            migrationBuilder.DropIndex(
                name: "IX_Companies_UserId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CompanyUser");

            migrationBuilder.DropColumn(
                name: "WorkExperienceId",
                table: "CompanyUser");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "CompanyUser",
                newName: "UsersUserId");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "CompanyUser",
                newName: "CompaniesCompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyUser_UserId",
                table: "CompanyUser",
                newName: "IX_CompanyUser_UsersUserId");

            migrationBuilder.AddColumn<int>(
                name: "User",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyUser",
                table: "CompanyUser",
                columns: new[] { "CompaniesCompanyId", "UsersUserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUser_Companies_CompaniesCompanyId",
                table: "CompanyUser",
                column: "CompaniesCompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUser_Users_UsersUserId",
                table: "CompanyUser",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
