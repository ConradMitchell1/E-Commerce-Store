using System.ComponentModel.DataAnnotations;

namespace RazorPageApp.Models
{
    public class LoginInputModel
    {
        [Required]
        public string Username { get; set; } = default!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = default!;
    }
}
