namespace RazorPageApp.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required string FirstName { get; set; }
        public string? LastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; } // Work on this
        public required DateTime RegistrationDate { get; set; }
    }
}
