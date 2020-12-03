using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class EmployeeBusiness
    {
        public readonly PersonRepository personRepository;
        public EmployeeBusiness()
        {
            List<PersonRepository> GetAllPersons()
            {
                return personRepository.GetAllEmployees();
            }
        }
    }
}
