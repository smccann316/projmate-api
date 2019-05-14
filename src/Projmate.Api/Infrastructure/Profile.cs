using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Projmate.Api.Models;

namespace Projmate.Api.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProjectEntity, Project>()
               .ForMember(des => des.Status, opt => opt.MapFrom(src => nameof(src.Status.GetName)));
        }
    }
}
