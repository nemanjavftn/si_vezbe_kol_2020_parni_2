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
        private readonly EmployeRepository employeRepository;

        public EmployeeBusiness()
        {
            this.employeRepository = new EmployeRepository();

        }

        public List<Employee> GetEmployees()
        {
            return this.employeRepository.GetAllEmployees();
        }
        public bool InsertEmployee(Employee e)
        {
            if (this.employeRepository.InsertEmployee(e) > 0)
            {
                return true;
            }
            return false;
        }

        public List<Employee> Rang(decimal Salaryfrom, decimal Salaryto)
        {
            return this.employeRepository.GetAllEmployees().Where(e => e.Salary > Salaryfrom && e.Salary < Salaryto).ToList();
        }
        
    }
}
