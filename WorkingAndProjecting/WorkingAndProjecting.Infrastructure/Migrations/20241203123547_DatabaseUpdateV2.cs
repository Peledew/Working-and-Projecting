using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkingAndProjecting.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseUpdateV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Workers_ManagerId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerProjects_Workers_WorkerId",
                table: "WorkerProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Departments_DepartmentId",
                table: "Workers");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Workers_ManagerId",
                table: "Workers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workers",
                table: "Workers");

            migrationBuilder.RenameTable(
                name: "Workers",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "WorkerProjects",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Workers_ManagerId",
                table: "Users",
                newName: "IX_Users_ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_Workers_DepartmentId",
                table: "Users",
                newName: "IX_Users_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_ManagerId",
                table: "Projects",
                column: "ManagerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_ManagerId",
                table: "Users",
                column: "ManagerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerProjects_Users_UserId",
                table: "WorkerProjects",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_ManagerId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_ManagerId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerProjects_Users_UserId",
                table: "WorkerProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Workers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "WorkerProjects",
                newName: "WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ManagerId",
                table: "Workers",
                newName: "IX_Workers_ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_DepartmentId",
                table: "Workers",
                newName: "IX_Workers_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workers",
                table: "Workers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Workers_ManagerId",
                table: "Projects",
                column: "ManagerId",
                principalTable: "Workers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerProjects_Workers_WorkerId",
                table: "WorkerProjects",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Departments_DepartmentId",
                table: "Workers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Workers_ManagerId",
                table: "Workers",
                column: "ManagerId",
                principalTable: "Workers",
                principalColumn: "Id");
        }
    }
}
