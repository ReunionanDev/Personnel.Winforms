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
        public PersonnelDBContext() : base()
        {
            Database.SetInitializer(new PersonnelDBInitializer()); // Use my custom DB initializer
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types().Configure(t => t.MapToStoredProcedures()); // Generate CUD stored procedures for all entities
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Establishment> Establishments { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
