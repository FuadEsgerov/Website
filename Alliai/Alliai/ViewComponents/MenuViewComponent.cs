using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alliai.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ShoppingRepostitories;

namespace Alliai.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentRepository _departmentRepository;
        public MenuViewComponent(IMapper mapper,
            IDepartmentRepository departmentRepository)
        {
            _mapper = mapper;
            _departmentRepository = departmentRepository;
        }
        public IViewComponentResult Invoke()
        {
            var departments = _departmentRepository.GetDepartmentsWithCategories();
            var model = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(departments);
          
            return View(model);
        }
    }
}
