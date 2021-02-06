using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Entities.Concrete.IdentityLibraryEntites;
using ToDoList.Entities.DTO;

namespace ToDoList.Bussiness.EntityMapper.AutoMapper
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<UserAddDto, AppUser>();
            CreateMap<AppUser, UserAddDto>();

            CreateMap<UserUpdateDto, AppUser>();
            CreateMap<AppUser, UserUpdateDto>();

            CreateMap<AppUser, UserSignInDto>();
            CreateMap<UserSignInDto, AppUser>();
        }
    }
}
