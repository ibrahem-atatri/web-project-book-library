using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibrary.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    bookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bookGenre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bookCoverImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.bookId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userPassword = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    userAdmin = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "bookId", "bookCoverImage", "bookGenre", "bookName" },
                values: new object[,]
                {
                    { 1, "https://example.com/harry-potter.jpg", "Fantasy", "Harry Potter and the Philosopher's Stone" },
                    { 2, "https://example.com/game-of-thrones.jpg", "Fantasy", "A Game of Thrones" },
                    { 3, "https://example.com/the-shining.jpg", "Horror", "The Shining" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "userAdmin", "userEmail", "userName", "userPassword" },
                values: new object[,]
                {
                    { 1, true, "admin@gmail.com", "Admin", "Admin@123" },
                    { 2, false, "johndoe@gmail.com", "JohnDoe", "JohnDoe@123" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
