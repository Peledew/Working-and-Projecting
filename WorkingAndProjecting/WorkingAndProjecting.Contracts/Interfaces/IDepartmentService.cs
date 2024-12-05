using WorkingAndProjecting.Contracts.DTOs;

namespace WorkingAndProjecting.Contracts.Interfaces
{
    public interface IDepartmentService
    {
        Task<List<DepartmentDto>?> GetAllAsync();
        Task<DepartmentDto?> GetByIdAsync(int id);
        Task<DepartmentDto> AddAsync(DepartmentDto department);
        Task<DepartmentDto?> DeleteAsync(int id);
        Task<DepartmentDto> UpdateAsync(DepartmentDto department);
    }
}
