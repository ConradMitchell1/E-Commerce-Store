using System.ComponentModel.DataAnnotations;

namespace RazorPageApp.Models
{
    public class RegisterInputModel
    {
        [Required]
        public string Username { get; set; } = default!;
        [Required]
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = default!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = default!;
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; } = default!;
    }
}
