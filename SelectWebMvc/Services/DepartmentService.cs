using SelectWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SelectWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SelectWebMvcContext _context;

        public DepartmentService(SelectWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
