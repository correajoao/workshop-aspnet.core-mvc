using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SelectWebMvc.Models;

namespace SelectWebMvc.Data
{
    public class SelectWebMvcContext : DbContext
    {
        public SelectWebMvcContext (DbContextOptions<SelectWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SelectWebMvc.Models.Department> Department { get; set; }
    }
}
