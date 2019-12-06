using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Personnel.BOL;

namespace Personnel.DAL
{
    public class PersonnelDBInitializer : DropCreateDatabaseIfModelChanges<PersonnelDBContext>
    {
        protected override void Seed(PersonnelDBContext context)
        {
            Role Stagiaire = new Role()
            {
                Id = "ST",
                Label = "Stagiaire",
                MinimumSalary = 800
            };

            Establishment Establishment1 = new Establishment()
            {
                Siret = "12345678200010",
                Name = "AFPA BRIVE",
                Adress = "53 rue Maurice Rollinat",
                Town = "BRIVE LA GAILLARDE",
                PostCode = 19100,
                Employees = new List<Employee>()
                {
                new Employee()
                {
                    EmployeeID = "12ABC12", BirthDate = new DateTime(1988,08,30), FirstName = "Gael", LastName = "RAMIDGE", StartDate = new DateTime(2019,07,01), RoleId = "ST", WorkQuantity = 1
                }
                }
            };
            context.Roles.Add(Stagiaire);
            context.Establishments.Add(Establishment1);
            base.Seed(context);
        }
    }
}
