namespace MyWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; }
        public string? Mobile { get; set; }
        public string Email { get; set; } = string.Empty;
    }
}
