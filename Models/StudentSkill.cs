using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Student_Mgmt_System.Models
{
    public class StudentSkill
    {
        [Key]
        public int SkillId { get; set; }

        [Required, ForeignKey("Student")]
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }

        [Required]
        public string SkillName { get; set; } // e.g., "Python for AI"
    }
}
