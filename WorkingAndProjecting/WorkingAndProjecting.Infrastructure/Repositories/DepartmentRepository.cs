using WorkingAndProjecting.Contracts.Interfaces;
using WorkingAndProjecting.Domain.Entities;

namespace WorkingAndProjecting.Infrastructure.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public Task AddAsync(Department department)
        {
            throw new NotImplementedException();
        }

        public Task<Department> DeleteAsync(Department department)
        {
            throw new NotImplementedException();
        }

        public Task<List<Department>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Department?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
