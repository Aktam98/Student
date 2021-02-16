using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPPWEB.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeContext _employeeContext;
        public EmployeeRepository(EmployeeContext employee)
        {
            _employeeContext = employee;
        }
        public void AddEmployee(Employee employee)
        {
            _employeeContext.employees.Add(employee);
            _employeeContext.SaveChanges();
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return (IEnumerable<Employee>)_employeeContext.employees;
        }

        public Employee GetEmployee(int id)
        {
            var result = from s in _employeeContext.employees
                         where s.Id.Equals(id)
                         select s;
            return (Employee)result;

        }
    }
}
