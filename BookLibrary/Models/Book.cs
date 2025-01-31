

using System.ComponentModel.DataAnnotations;
namespace BookLibrary.Models
{
    public class Book
    {
        // EF Core will configure the database to generate this value
        public int bookId { get; set; }

        [Required(ErrorMessage = "Please enter a book name.")]
        public string bookName { get; set; } = string.Empty;
      
        [Required(ErrorMessage = "Please enter a book genre.")]
        public string? bookGenre { get; set; }

        [Required(ErrorMessage = "Please enter a cover image.")]
        public string? bookCoverImage { get; set; }

    }

}