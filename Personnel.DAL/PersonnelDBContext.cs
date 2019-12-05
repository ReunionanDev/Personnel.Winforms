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
            //Database.SetInitializer<PersonnelDBContext>(new CreateDatabaseIfNotExists<PersonnelDBContext>());
            //Database.SetInitializer<PersonnelDBContext>(new DropCreateDatabaseIfModelChanges<PersonnelDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
            Database.SetInitializer(new PersonnelDBInitializer());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Establishment> Establishments { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
