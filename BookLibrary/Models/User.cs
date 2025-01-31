using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Models
{
    public class User
    {
        // EF Core will configure the database to generate this value
        public int userId { get; set; }

        [Required(ErrorMessage = "Please enter a user name.")]
        public string userName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a user email.")]
        //[EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? userEmail { get; set; }


        [Required(ErrorMessage = "Password is required.")]
        //[DataType(DataType.Password)]
        
        public string? userPassword { get; set; }

        public bool? userAdmin { get; set; } = false;


    }
}