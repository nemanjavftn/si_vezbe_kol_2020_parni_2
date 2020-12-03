using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, string surname, decimal salary)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return this.Id + "." + this.Name + " " + this.Surname + " " + this.Salary;
        }
    }
}
