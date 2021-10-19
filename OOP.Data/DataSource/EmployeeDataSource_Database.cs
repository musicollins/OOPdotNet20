using OOP.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace OOP.Data.DataSource
{
    public class EmployeeDataSource_Database : AbstractDataSource
    {
        public override List<Employee> ProvideEmployees()
        {

            //This Data Is Coming From A "DataBase"
            Debug.WriteLine("###DataBase");
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Ralph", Email = "ralph@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Anna", Email = "anna@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Juan", Email = "donjuan@gmail.com" });
            Employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "blcja", Email = "moste@gmail.com" });

            return Employees;
        }
    }
}
