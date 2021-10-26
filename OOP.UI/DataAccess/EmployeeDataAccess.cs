using OOP.Data;
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
        private readonly IEmployeeDataSource _dataSource;

        public List<Employee> Employees{ get; set; }
        public EmployeeDataAccess(IEmployeeDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public List<Employee> GetEmployees()
        {
            //Todo:
            //Get All Employees from Data Source
            
            return _dataSource.GetAll();
        }
    }
}
