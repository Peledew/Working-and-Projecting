using WorkingAndProjecting.Domain.Entities;

namespace WorkingAndProjecting.Contracts.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetAllAsync();
        Task<Department?> GetByIdAsync(int id);
        Task AddAsync(Department department);
        Task<Department> DeleteAsync(Department department);
        Task SaveChangesAsync();
    }
}
