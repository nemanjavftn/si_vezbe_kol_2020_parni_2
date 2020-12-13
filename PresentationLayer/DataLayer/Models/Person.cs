using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Person
    {
        public Person(int id, string name, string surname, decimal salary)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.salary = salary;
        }

        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public decimal salary { get; set; }
        public override string ToString()
        {
            return $"{id} {name} {surname} {salary}";
        }
    }
}
    
