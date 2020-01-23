using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using Newtonsoft.Json;

namespace EmployeeManagementSystem.DataRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetAllEmployees()
        {
            try
            {
                return GetEmployeeList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            ;
        }

        public bool AddEmployee(Employee employee)
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool DeleteEmployee(int employeeId)
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool EditEmployee(Employee employee)
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }


        private List<Employee> GetEmployeeList()
        {
            var directory = AppDomain.CurrentDomain.BaseDirectory;
            var path = $"{directory}//DataRepository//employeeList.json";
            var json = File.ReadAllText(path);
            var employees = JsonConvert.DeserializeObject<List<Employee>>(json);
            return employees;
        }
    }
}