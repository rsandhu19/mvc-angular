using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();

        Employee GetEmployeeById(int employeeId);

        List<Employee> GetEmployeeByName(string firstName, string lastName);

        bool AddEmployee(Employee employee);

        bool DeleteEmployee(int employee);

        bool ModifyEmployee(Employee employee);
    }
}
