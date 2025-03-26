using Microsoft.EntityFrameworkCore;
using Student_Mgmt_System.Data;
using Student_Mgmt_System.Models;
using Student_Mgmt_System.RepositoryPattern.Interfaces;

namespace Student_Mgmt_System.RepositoryPattern.Implementation
{
    public class StudentService : IStudent
    {
        private readonly StudentDbContext _context;
        public StudentService(StudentDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task AddStudentAsync(Student student)
        {
            await _context.Students.AddAsync(student);
        }
    }
}
