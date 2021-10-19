using OOP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.UI.DataAccess
{
    public class EmployeeDataAccess
    {
        public List<Employee> Employees{ get; set; }

        public List<Employee> GetEmployees()
        {
            //Todo:
            //Get All Employees from Data Source
            return new List<Employee>();
        }
    }
}
