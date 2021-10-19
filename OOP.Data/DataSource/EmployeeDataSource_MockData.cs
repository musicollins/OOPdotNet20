using OOP.Model;
using System;
using System.Collections.Generic;

namespace OOP.Data
{
    public class EmployeeDataSource_MockData
    {

        public List<Employee> Employees { get; set; }
        
        public List<Employee> ProvideEmployees()
        {
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Ralph", Email = "ralph@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Anna", Email = "anna@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Juan", Email = "donjuan@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "blcja", Email = "moste@gmail.com" });

            return Employees;
        }
    }
}
