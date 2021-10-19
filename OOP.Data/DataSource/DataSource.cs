using OOP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Data.DataSource
{
    public abstract class AbstractDataSource
    {
        public List<Employee> Employees { get; set; }
        public AbstractDataSource()
        {
            Employees = new List<Employee>();
        }

        //public List<Employee> ProvideEmployees()
        //{
        //    Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Ralph", Email = "ralph@gmail.com" });
        //    Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Anna", Email = "anna@gmail.com" });
        //    Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Juan", Email = "donjuan@gmail.com" });
        //    Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "blcja", Email = "moste@gmail.com" });

        //    return Employees;
        //}
        public abstract List<Employee> ProvideEmployees();
    }
}
