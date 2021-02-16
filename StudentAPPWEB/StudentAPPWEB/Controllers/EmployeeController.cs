using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentAPPWEB.Models;
using Microsoft.EntityFrameworkCore.Design;

namespace StudentAPPWEB.Controllers
{
    public class EmployeeController:Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public ViewResult Index()
        {
            IEnumerable<Employee> employees = _employeeRepository.GetAllEmployee();
            return View(employees);
        }
        [HttpGet]
        public IActionResult Create()
        {         
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _employeeRepository.AddEmployee(employee);
            return View();
        }
    }
}
