using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEmployee
{
    public class BusinessEmployee
    {
        private readonly EmployeeRepository employeeRepository;


        public BusinessEmployee()
        {
            employeeRepository = new EmployeeRepository();
        }
        public List<Employee> GetEmployees()
        {
            return employeeRepository.GetEmployees();
        }

        public bool InsertEmployee(Employee employee)
        {
            if (employeeRepository.InsertEmployee(employee) > 0)
                return true;
            return false;
        }

        public List<Employee> GetEmployeesBetween(decimal min, decimal max)
        {
            return employeeRepository.GetEmployees().Where(s => s.Salary < max && s.Salary > min).ToList();
        }

    }
}
