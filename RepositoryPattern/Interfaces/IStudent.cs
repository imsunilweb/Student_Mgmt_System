using Student_Mgmt_System.Models;

namespace Student_Mgmt_System.RepositoryPattern.Interfaces
{
    public interface IStudent
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentByIdAsync(int id);
        Task AddStudentAsync(Student student);
    }
}
