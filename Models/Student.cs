using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Required]
        public string Phone { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; } = DateTime.Now;

        [Required, ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        
    }
}
