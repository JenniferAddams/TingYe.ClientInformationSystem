using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientInformationSystem.Core.ServiceInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientInformationSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {        
        //initialize
        private readonly IEmployeeService _employeeService;

        //depedency injection
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        [Route("EmployeeList")]
        //http://localhost:2283/api/employee/employeelist
        //we want the this page show employee list ---the home page
        public async Task<IActionResult> GetAllEmployee()
        {
            var employee = await _employeeService.GetALLEmployees();
            return Ok(employee);
        }

    }
}
