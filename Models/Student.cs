using System.ComponentModel.DataAnnotations;

namespace Student_Mgmt_System.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Course { get; set; }

        public DateTime EnrollmentDate { get; set; } = DateTime.Now;
    }
}
