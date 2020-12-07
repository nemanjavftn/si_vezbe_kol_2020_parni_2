using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BusinessLayer
{   
    public class EmployeeBusiness
        
    {
        private readonly EmployeeRepository employeeRepositoryl;
        public EmployeeBusiness()
        {
            this.employeeRepositoryl = new EmployeeRepository(); 
        }
        public List<Employee> GetEmployees(decimal a, decimal b)
        {
            return this.employeeRepositoryl.GettAllEmployees().Where(n => n.Salary > a && n.Salary < b).ToList();
        }
        public List<Employee> GetAllEmployees()
        {
            return this.employeeRepositoryl.GettAllEmployees();
        }
        public bool insertEmpoyee(Employee s)
        {
            if (this.employeeRepositoryl.InsertEmpoyee(s) > 0)
            {
                return true;
            }
            else return false;
        }
    }
}
