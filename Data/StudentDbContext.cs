using Microsoft.EntityFrameworkCore;
using Student_Mgmt_System.Models;

namespace Student_Mgmt_System.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSkill> StudentSkills { get; set; }

    }
   
}
