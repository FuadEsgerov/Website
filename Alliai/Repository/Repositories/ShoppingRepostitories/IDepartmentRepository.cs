using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ShoppingRepostitories
{
  public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartmentsWithCategories();
    }
}
