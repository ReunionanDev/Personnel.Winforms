﻿using System;
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
            PersonnelDBContext personnelDBContext = new PersonnelDBContext();
            return personnelDBContext.Employees.Include("Establishment").ToList();
        }

        public List<Establishment> GetEstablishment()
        {
            PersonnelDBContext personnelDBContext = new PersonnelDBContext();
            return personnelDBContext.Establishments.ToList();
        }
    }
}
