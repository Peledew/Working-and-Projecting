using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingAndProjecting.Contracts.DTOs;
using WorkingAndProjecting.Domain.Entities;

namespace WorkingAndProjecting.Contracts.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllAsync();
        Task<UserDto?> GetByIdAsync(int id);
        Task<UserDto> AddAsync(UserDto user);
        Task<UserDto?> DeleteAsync(int id);
        Task SaveChangesAsync();
        Task<UserDto> UpdateAsync(UserDto user);
    }
}
