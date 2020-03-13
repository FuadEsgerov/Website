using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alliai.Models
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
    }
}
