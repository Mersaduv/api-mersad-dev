using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mersad_dev.Migrations
{
    /// <inheritdoc />
    public partial class ModifyCourseThumbnailFileSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ThumbnailFileSize",
                table: "InitCourses",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ThumbnailFileSize",
                table: "InitCourses",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
