using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeBusiness
    {
        public readonly EmployeeRepository employeeRepository;


        public EmployeeBusiness()
        {
            this.employeeRepository = new EmployeeRepository();
        }

        public List<Employee> GetEmployeess()
        {
            return this.employeeRepository.GetEmployess();

        }
        public bool InsertE(Employee e)
        {
            if(this.employeeRepository.Insert(e)> 0)
            {
                return true;
            }
            return false;
        }
        public List<Employee> Salary(decimal m, decimal r)
        {
            return this.employeeRepository.GetEmployess().Where(s => s.Salary > m && s.Salary < r).ToList(); 
        }
    }

}
