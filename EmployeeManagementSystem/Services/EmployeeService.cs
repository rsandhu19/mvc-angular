using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using Newtonsoft.Json;

namespace EmployeeManagementSystem.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        
        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            var employeeList = _employeeRepository.GetAllEmployees();
            return employeeList.FirstOrDefault(e => e.EmployeeId == employeeId);
        }

        public List<Employee> GetEmployeeByName(string firstName,string lastName)
        {
            var employeeList = _employeeRepository.GetAllEmployees();
            return employeeList.FindAll(e => e.FirstName == firstName || e.LastName == lastName);
        }

        public bool AddEmployee(Employee employee)
        {
            return _employeeRepository.AddEmployee(employee);
        }

        public bool DeleteEmployee(int employeeId)
        {
            return _employeeRepository.DeleteEmployee(employeeId);
        }

        public bool ModifyEmployee(Employee employee)
        {
            return _employeeRepository.EditEmployee(employee);
        }
    }
}