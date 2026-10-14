using System.ComponentModel.DataAnnotations;

namespace pract6.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required field!!")]
        [StringLength(50)]
        public string? Name { get; set; }

        [Range(16, 100, ErrorMessage = "Age Must be between 16 and 100")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Format")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be exactly 10 digits")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "The Course details is required")]
        public string? Course { get; set; }
    }
}
