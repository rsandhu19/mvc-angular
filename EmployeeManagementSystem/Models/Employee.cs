using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeManagementSystem.Models.Enums;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HireDate { get; set; }

        public Role Role { get; set; }
    }
}