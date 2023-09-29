using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mersad_dev.Migrations
{
    /// <inheritdoc />
    public partial class ModifyDateTimeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThumbnailFileExtention",
                table: "InitCourses");

            migrationBuilder.AlterColumn<string>(
                name: "ThumbnailFileName",
                table: "InitCourses",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Thumbnail",
                table: "InitCourses",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea");

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailFileExtension",
                table: "InitCourses",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThumbnailFileExtension",
                table: "InitCourses");

            migrationBuilder.AlterColumn<string>(
                name: "ThumbnailFileName",
                table: "InitCourses",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Thumbnail",
                table: "InitCourses",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailFileExtention",
                table: "InitCourses",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
