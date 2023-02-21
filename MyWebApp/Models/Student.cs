using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;
        [MaxLength(100)]
        public string? LastName { get; set; }
        [MaxLength(15)]
        public string? Mobile { get; set; }
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;
    }
}
