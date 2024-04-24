using AutoMapper;
using Contracts.Requests;
using Contracts.Requests.User;
using Contracts.Responses;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Aplication.Common.Mapping
{
    internal class UserMapProfile : Profile
    {
        public UserMapProfile() 
        {
            CreateMap<CreateUserRequest, User>();
            CreateMap<User, SingleUserResponse>();
            CreateMap<GetAllUserRequest, GetAllUserResponse>();
            CreateMap<UpdateUserRequest, User>();
        }
    }
}
