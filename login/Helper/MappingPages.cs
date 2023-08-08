using AutoMapper;
using login.Dto;
using login.Models;

namespace login.Helper
{
    public class MappingPages: Profile
    {
        public MappingPages()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<User, DtoView>();
            CreateMap<DtoView, User>();
            CreateMap<User, DtoLogin>();
            CreateMap<DtoLogin, User>();
        }
    }
}
