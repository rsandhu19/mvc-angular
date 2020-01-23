using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();

        bool AddEmployee(Employee employee);

        bool DeleteEmployee(int employeeId);

        bool EditEmployee(Employee employee);
    }
}
