using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories.ShoppingRepostitories
{
    public class DepartmentRepository :IDepartmentRepository
    {
        private readonly AllaiaDbContext _context;
        public DepartmentRepository(AllaiaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Department> GetDepartmentsWithCategories()
        {
            return _context.Departments.
                Include("Categories")
                .Where(d => d.Status)
                .ToList();
        }
    }
}
