using Student_Mgmt_System.Data;
using Student_Mgmt_System.RepositoryPattern.Implementation;
using Student_Mgmt_System.RepositoryPattern.Interfaces;

namespace Student_Mgmt_System.UnitOfWorkPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentDbContext _context;
        private IStudent _students;

        public UnitOfWork(StudentDbContext context)
        {
            _context = context;
        }

        public IStudent Students => _students ??= new StudentService(_context);

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
