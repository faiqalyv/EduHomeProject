using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduHome.UI.Migrations
{
    public partial class CreateNoticeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_CourseCatagory_CourseCatagoryId",
                table: "courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseCatagory",
                table: "CourseCatagory");

            migrationBuilder.RenameTable(
                name: "CourseCatagory",
                newName: "courseCatagories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_courseCatagories",
                table: "courseCatagories",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "notices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notices", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_courses_courseCatagories_CourseCatagoryId",
                table: "courses",
                column: "CourseCatagoryId",
                principalTable: "courseCatagories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_courseCatagories_CourseCatagoryId",
                table: "courses");

            migrationBuilder.DropTable(
                name: "notices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courseCatagories",
                table: "courseCatagories");

            migrationBuilder.RenameTable(
                name: "courseCatagories",
                newName: "CourseCatagory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseCatagory",
                table: "CourseCatagory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_CourseCatagory_CourseCatagoryId",
                table: "courses",
                column: "CourseCatagoryId",
                principalTable: "CourseCatagory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
