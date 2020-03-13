using Alliai.Models;
using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alliai.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Department, DepartmentViewModel>();
        }
    }
}
