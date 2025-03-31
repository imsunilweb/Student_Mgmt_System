using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Student_Mgmt_System.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        [Required]
        public string SubjectName { get; set; }

        [Required, ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
