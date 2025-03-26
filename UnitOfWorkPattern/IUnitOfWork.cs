using Student_Mgmt_System.RepositoryPattern.Interfaces;

namespace Student_Mgmt_System.UnitOfWorkPattern
{
    public interface IUnitOfWork
    {
        IStudent Students { get; }
        Task SaveAsync();
    }
}
