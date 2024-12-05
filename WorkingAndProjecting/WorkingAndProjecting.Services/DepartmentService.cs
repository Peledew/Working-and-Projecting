using WorkingAndProjecting.Contracts.DTOs;
using WorkingAndProjecting.Contracts.Interfaces;

namespace WorkingAndProjecting.Services
{
    public class DepartmentService : IDepartmentService
    {
        public Task<DepartmentDto> AddAsync(DepartmentDto department)
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentDto?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DepartmentDto>?> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentDto?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentDto> UpdateAsync(DepartmentDto department)
        {
            throw new NotImplementedException();
        }
    }
}
