using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        { }

        // DbSet properties for each entity
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // Seed initial data for Books
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    bookId = 1,
                    bookName = "Harry Potter and the Philosopher's Stone",
                    bookGenre = "Fantasy",
                    bookCoverImage = "https://notionpress.com/blog/wp-content/uploads/2015/07/001-book-brand-cover-back-presentation-mockup-psd.jpg",

                },
                new Book
                {
                    bookId = 2,
                    bookName = "A Game of Thrones",
                    bookGenre = "Fantasy",
                    bookCoverImage = "https://notionpress.com/blog/wp-content/uploads/2015/07/001-book-brand-cover-back-presentation-mockup-psd.jpg",

                },
                new Book
                {
                    bookId = 3,
                    bookName = "The Shining",
                    bookGenre = "Horror",
                    bookCoverImage = "https://notionpress.com/blog/wp-content/uploads/2015/07/001-book-brand-cover-back-presentation-mockup-psd.jpg",

                }
            );

            // Seed initial data for Users
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    userId = 1,
                    userName = "Admin",
                    userEmail = "admin@gmail.com",
                    userPassword = "Admin@123", // Note: Passwords should be hashed in a real application
                    userAdmin = true
                },
                new User
                {
                    userId = 2,
                    userName = "JohnDoe",
                    userEmail = "johndoe@gmail.com",
                    userPassword = "JohnDoe@123", // Note: Passwords should be hashed in a real application
                    userAdmin = false
                }
            );


        }
    }
}