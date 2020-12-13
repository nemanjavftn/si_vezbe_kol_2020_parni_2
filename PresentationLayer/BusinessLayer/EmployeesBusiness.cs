using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeesBusiness
    {

        EmployeesRepository er;

        public EmployeesBusiness()
        {
            this.er = new EmployeesRepository();
        }
        public List<Person> PersonList()
        {
            return this.er.getPerson();

        }
        public bool insertPerson( Person p)
        {
            int result = this.er.insertPerson(p);
            if (result != 0)
            {
                return true;
            }
            return false;
        }



    }
}
