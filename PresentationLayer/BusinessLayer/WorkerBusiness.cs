using AccessDataLayer;
using AccessDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class WorkerBusiness
    {
        public readonly WorkerRepository workerRepository;
        public WorkerBusiness()
        {
            this.workerRepository = new WorkerRepository();
        }
        public List<Worker> GetEmloyees()
        {
            return this.workerRepository.GetAllEmployees();
        }
        public bool Insert(Worker w)
        {
            if (this.workerRepository.Insert(w) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
