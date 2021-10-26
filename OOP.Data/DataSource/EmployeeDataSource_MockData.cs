using OOP.Model;
using System;
using System.Collections.Generic;

namespace OOP.Data
{
    public class EmployeeDataSource_MockData : IEmployeeDataSource

    {

        public List<Employee> Employees { get; set; }
        public EmployeeDataSource_MockData()
        {
            Load();
        }
        void Load()
        {
            Employees = new List<Employee>()
            {
                new Employee() { Id = Guid.NewGuid(), Name = "Ralph", Email = "ralph@gmail.com" },
                new Employee() { Id = Guid.NewGuid(), Name = "Anna", Email = "anna@gmail.com" },
                new Employee() { Id = Guid.NewGuid(), Name = "Juan", Email = "donjuan@gmail.com" },
                new Employee() { Id = Guid.NewGuid(), Name = "blcja", Email = "moste@gmail.com" }
            };
        }

        public List<Employee> GetAll()
        {

            return Employees;
        }
    }
}
