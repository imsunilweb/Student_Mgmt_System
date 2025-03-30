using System.ComponentModel.DataAnnotations;

namespace Student_Mgmt_System.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Course { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; } = DateTime.Now;
    }
}
