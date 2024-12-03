using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WorkingAndProjecting.Contracts.DTOs;
using WorkingAndProjecting.Contracts.Interfaces;
using WorkingAndProjecting.Domain.Entities;


namespace WorkingAndProjecting.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
       // private readonly IHttpContextAccessor _httpContextAccessor;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
          //  _httpContextAccessor = httpContextAccessor;
        }

        //public int GetCurrentUserId()
        //{
        //    var userIdClaim = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier);
        //    return userIdClaim != null ? int.Parse(userIdClaim.Value) : throw new Exception("User not authenticated");
        //}

        public async Task<UserDto> AddAsync(UserDto user)
        {
            await _userRepository.AddAsync(_mapper.Map<UserDto, User>(user));
            return user;
        }

        public async Task<UserDto?> DeleteAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
                return null;

            var deletedUser = await _userRepository.DeleteAsync(user);
            return _mapper.Map<User, UserDto>(deletedUser);
            
        }

        public async Task<List<UserDto>?> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            if (!users.Any())
                return null;

            return _mapper.Map<List<UserDto>>(users);
        }

        public async Task<UserDto?> GetByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
                return null;

            return _mapper.Map<User, UserDto>(user);
        }

        public Task<UserDto> UpdateAsync(UserDto user)
        {
            throw new NotImplementedException();
        }
    }
}
