using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mersad_dev.Migrations
{
    /// <inheritdoc />
    public partial class InitCourseThumbnails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Thumbnail",
                table: "InitCourses",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailFileExtention",
                table: "InitCourses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailFileName",
                table: "InitCourses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ThumbnailFileSize",
                table: "InitCourses",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "InitCourses");

            migrationBuilder.DropColumn(
                name: "ThumbnailFileExtention",
                table: "InitCourses");

            migrationBuilder.DropColumn(
                name: "ThumbnailFileName",
                table: "InitCourses");

            migrationBuilder.DropColumn(
                name: "ThumbnailFileSize",
                table: "InitCourses");
        }
    }
}
