using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingAndProjecting.Contracts.DTOs;
using WorkingAndProjecting.Contracts.Interfaces;

namespace WorkingAndProjecting.Services
{
    public class UserService : IUserService
    {
        public Task AddAsync(UserDto user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(UserDto user)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserDto?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> UpdateAsync(UserDto user)
        {
            throw new NotImplementedException();
        }
    }
}
