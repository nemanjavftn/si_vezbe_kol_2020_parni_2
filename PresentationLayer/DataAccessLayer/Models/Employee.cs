using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
   public class Employee : Person
    {
        private decimal salary;

        public decimal Salary { get => salary; set => salary = value; }
    }
}
