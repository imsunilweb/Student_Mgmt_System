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
    }
   
}
