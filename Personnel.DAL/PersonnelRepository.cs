using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Personnel.BOL;

namespace Personnel.DAL
{
    public class PersonnelRepository
    {
        
        public List<Employee> GetEmployees()
        {
            return new PersonnelDBContext().Employees.ToList();
        }
    }
}
