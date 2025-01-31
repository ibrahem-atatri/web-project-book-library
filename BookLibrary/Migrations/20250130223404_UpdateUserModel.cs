using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibrary.Migrations
{
    public partial class UpdateUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "userPassword",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "bookId",
                keyValue: 1,
                column: "bookCoverImage",
                value: "https://notionpress.com/blog/wp-content/uploads/2015/07/001-book-brand-cover-back-presentation-mockup-psd.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "bookId",
                keyValue: 2,
                column: "bookCoverImage",
                value: "https://notionpress.com/blog/wp-content/uploads/2015/07/001-book-brand-cover-back-presentation-mockup-psd.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "bookId",
                keyValue: 3,
                column: "bookCoverImage",
                value: "https://notionpress.com/blog/wp-content/uploads/2015/07/001-book-brand-cover-back-presentation-mockup-psd.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "userPassword",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "bookId",
                keyValue: 1,
                column: "bookCoverImage",
                value: "https://example.com/harry-potter.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "bookId",
                keyValue: 2,
                column: "bookCoverImage",
                value: "https://example.com/game-of-thrones.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "bookId",
                keyValue: 3,
                column: "bookCoverImage",
                value: "https://example.com/the-shining.jpg");
        }
    }
}
