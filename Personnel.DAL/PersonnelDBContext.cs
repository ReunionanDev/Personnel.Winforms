using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Personnel.BOL;

namespace Personnel.DAL
{
    public class PersonnelDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Establishment> Establishments { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
