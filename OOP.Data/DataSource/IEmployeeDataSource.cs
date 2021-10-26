using OOP.Model;
using System.Collections.Generic;

namespace OOP.Data
{
    public interface IEmployeeDataSource
    {
        List<Employee> GetAll();
    }
}