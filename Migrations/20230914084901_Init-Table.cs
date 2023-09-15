using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace mersad_dev.Migrations
{
    /// <inheritdoc />
    public partial class InitTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    IsOnline = table.Column<bool>(type: "boolean", nullable: false),
                    Tuition = table.Column<double>(type: "double precision", nullable: false),
                    Instructor = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Category", "CategoryId", "Created", "Instructor", "IsOnline", "LastUpdated", "Title", "Tuition" },
                values: new object[,]
                {
                    { new Guid("78debb24-e076-4f5a-a7ee-c84470463b70"), "course", 1, new DateTime(2023, 9, 14, 8, 49, 1, 33, DateTimeKind.Utc).AddTicks(4711), "mrsd", true, new DateTime(2023, 9, 14, 8, 49, 1, 33, DateTimeKind.Utc).AddTicks(4717), "evlore,pw", 100.0 },
                    { new Guid("de933b40-8150-4bc3-8f9f-29419fc6d136"), "course", 1, new DateTime(2023, 9, 14, 8, 49, 1, 33, DateTimeKind.Utc).AddTicks(4721), "mrsd 2", true, new DateTime(2023, 9, 14, 8, 49, 1, 33, DateTimeKind.Utc).AddTicks(4722), "evlore,pw", 200.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
