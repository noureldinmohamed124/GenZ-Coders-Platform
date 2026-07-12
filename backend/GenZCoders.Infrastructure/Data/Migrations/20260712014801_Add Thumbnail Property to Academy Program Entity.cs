using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenZCoders.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddThumbnailPropertytoAcademyProgramEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThumbnailUrl",
                table: "AcademyPrograms",
                type: "varchar(500)",
                unicode: false,
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThumbnailUrl",
                table: "AcademyPrograms");
        }
    }
}
