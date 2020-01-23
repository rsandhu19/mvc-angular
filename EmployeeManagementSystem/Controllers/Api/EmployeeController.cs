using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Controllers.Api
{
    [RoutePrefix("api/Employee")]
    public class EmployeeController : ApiController
    {
        readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var employees = _employeeService.GetAllEmployees();
            return employees;
        }

        [HttpPost]
        [Route("addEmployee")]
        public void Post([FromBody]Employee employee)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpPost]
        [Route("deleteEmployee")]
        public void Delete(int employeeId)
        {
        }
    }
}
