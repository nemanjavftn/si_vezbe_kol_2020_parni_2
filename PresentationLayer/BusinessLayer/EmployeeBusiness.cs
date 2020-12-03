using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
  public class EmployeeBusiness
    {
        private readonly EmployeeRepository employeeRepository;

        public EmployeeBusiness()
        {
            this.employeeRepository = new EmployeeRepository();
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeRepository.GetAllEmployees();
        }

        public List<Employee> getEmployeesSalary(decimal value)
        {
            return this.employeeRepository.GetAllEmployees()
                .Where(e => e.Salary = value).ToList();
        }
    }
}
