using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OfficeEMP.Models;

namespace OfficeEmp.Data
{
    public class OfficeEmpContext : DbContext
    {
        public OfficeEmpContext (DbContextOptions<OfficeEmpContext> options)
            : base(options)
        {
        }

        public DbSet<OfficeEMP.Models.Employee> Employee { get; set; } = default!;
    }
}
