using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingAndProjecting.Contracts.DTOs;
using WorkingAndProjecting.Domain.Entities;

namespace WorkingAndProjecting.Contracts.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
