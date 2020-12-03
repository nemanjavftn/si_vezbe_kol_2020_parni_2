using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class Business
    {
        private readonly EmployeeRepository repository;

        public Business()
        {
            this.repository = new EmployeeRepository();
        }
        public List<Employee> GetEmployees()
        {
            return this.repository.GetAllEmployees();
        }
        public bool InsertOneEmployee(Employee e)
        {
            if (this.repository.InsertEmployee(e) > 0)
            {
                return true;
            }
            return false;
        }
        public List<Employee> BetweenSalary(decimal salary1, decimal salary2)
        {
            return this.repository.GetAllEmployees().Where(e => e.Salary > salary1 && e.Salary < salary2).ToList();
        }
    }
}
