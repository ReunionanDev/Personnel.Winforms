using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Personnel.BOL;

namespace Personnel.DAL
{
    public class PersonnelDBInitializer : CreateDatabaseIfNotExists<PersonnelDBContext>
    {
        //Populate the database with samples
        protected override void Seed(PersonnelDBContext context)
        {
            IList<Role> defaultRoles = new List<Role>();
            defaultRoles.Add(new Role() { Id = "ST", Label = "Stagiaire", MinimumSalary = 800 });
            defaultRoles.Add(new Role() { Id = "FM", Label = "Formateur", MinimumSalary = 1950.50m });
            defaultRoles.Add(new Role() { Id = "DT", Label = "Directeur", MinimumSalary = 2200.75m });
            context.Roles.AddRange(defaultRoles);

            IList<Establishment> defaultEstablishments = new List<Establishment>();
            defaultEstablishments.Add(new Establishment() { Siret = "12345678200010", Name = "AFPA BRIVE", Adress = "53 rue Maurice Rollinat", Town = "BRIVE LA GAILLARDE", PostCode = 19100, });
            defaultEstablishments.Add(new Establishment() { Siret = "78945612600018", Name = "AFPA PERIGUEUX", Adress = "45 rue de la Paix", Town = "PERIGUEUX", PostCode = 24750, });
            defaultEstablishments.Add(new Establishment() { Siret = "45678912200011", Name = "AFPA GRENOBLE", Adress = "12 rue des azalées", Town = "GRENOBLE", PostCode = 38000, });
            context.Establishments.AddRange(defaultEstablishments);

            IList<Employee> defaultEmployees = new List<Employee>();
            defaultEmployees.Add(new Employee() { EmployeeID = "12ABC12", BirthDate = new DateTime(1988, 08, 30), FirstName = "Gael", LastName = "RAMIDGE", StartDate = new DateTime(2019, 07, 01), RoleId = "ST", WorkQuantity = 1, GrossSalary = 1250.50m, EstablishmentSiret = "12345678200010" });
            defaultEmployees.Add(new Employee() { EmployeeID = "34DEF34", BirthDate = new DateTime(1990, 04, 01), FirstName = "Pierrot", LastName = "LEBON", StartDate = new DateTime(1995, 04, 01), EndDate = new DateTime(2019,01,01), RoleId = "FM", WorkQuantity = 1, GrossSalary = 2242.45m, EstablishmentSiret = "12345678200010" });
            defaultEmployees.Add(new Employee() { EmployeeID = "56GHI56", BirthDate = new DateTime(1982, 12, 15), FirstName = "Benjamin", LastName = "LEBRETON", StartDate = new DateTime(2004, 08, 01), RoleId = "FM", WorkQuantity = 0.5, GrossSalary = 2879.21m, EstablishmentSiret = "12345678200010" });
            defaultEmployees.Add(new Employee() { EmployeeID = "78JKL78", BirthDate = new DateTime(1975, 01, 01), FirstName = "Fabrice", LastName = "DUPONT", StartDate = new DateTime(2001, 01, 01), RoleId = "DT", WorkQuantity = 1, GrossSalary = 3690.90m, EstablishmentSiret = "12345678200010" });
            defaultEmployees.Add(new Employee() { EmployeeID = "99MNO11", BirthDate = new DateTime(1985, 07, 24), FirstName = "Pierre Antoine", LastName = "DORIGNY", StartDate = new DateTime(2019, 09, 05), RoleId = "ST", WorkQuantity = 1, GrossSalary = 1420, EstablishmentSiret = "78945612600018" });
            defaultEmployees.Add(new Employee() { EmployeeID = "58BFR68", BirthDate = new DateTime(1993, 02, 07), FirstName = "Hilde", LastName = "OSLAND", StartDate = new DateTime(2019, 07, 01), RoleId = "ST", WorkQuantity = 1, GrossSalary = 800, EstablishmentSiret = "78945612600018" });
            defaultEmployees.Add(new Employee() { EmployeeID = "19LBZ54", BirthDate = new DateTime(1970, 11, 30), FirstName = "Chantale", LastName = "IMELE", StartDate = new DateTime(2004, 06, 09), RoleId = "FM", WorkQuantity = 1, GrossSalary = 2365, EstablishmentSiret = "78945612600018" });
            defaultEmployees.Add(new Employee() { EmployeeID = "22LKP99", BirthDate = new DateTime(1981, 05, 22), FirstName = "Katrin", LastName = "KROSTINOVA", StartDate = new DateTime(2002, 02, 19), RoleId = "DT", WorkQuantity = 1, GrossSalary = 5260.45m, EstablishmentSiret = "78945612600018" });
            defaultEmployees.Add(new Employee() { EmployeeID = "98AOA05", BirthDate = new DateTime(1978, 06, 18), FirstName = "Violette", LastName = "SUMMERS", StartDate = new DateTime(2017, 05, 25), EndDate = new DateTime(2017, 04, 01), RoleId = "ST", WorkQuantity = 1, GrossSalary = 900, EstablishmentSiret = "45678912200011" });
            defaultEmployees.Add(new Employee() { EmployeeID = "27NYX06", BirthDate = new DateTime(1991, 03, 08), FirstName = "Kevin", LastName = "HOARAU", StartDate = new DateTime(2019, 05, 01), RoleId = "FM", WorkQuantity = 1, GrossSalary = 2900, EstablishmentSiret = "45678912200011" });
            defaultEmployees.Add(new Employee() { EmployeeID = "57FDQ45", BirthDate = new DateTime(1994, 10, 17), FirstName = "Julie", LastName = "HANNE", StartDate = new DateTime(1998, 02, 14), RoleId = "FM", WorkQuantity = 0.5, GrossSalary = 2000, EstablishmentSiret = "45678912200011" });
            defaultEmployees.Add(new Employee() { EmployeeID = "08NMI39", BirthDate = new DateTime(1977, 09, 11), FirstName = "Laurent", LastName = "PAYET", StartDate = new DateTime(2002, 01, 29), RoleId = "DT", WorkQuantity = 1, GrossSalary = 4555.30m, EstablishmentSiret = "45678912200011" });
            context.Employees.AddRange(defaultEmployees);

            base.Seed(context);
        }
    }
}
