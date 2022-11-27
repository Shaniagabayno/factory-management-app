using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Web.Http.Cors;
using Project1.Models;
namespace Project1.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmployeeController : ApiController
    {
        static EmployeeBL bl = new EmployeeBL();
        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            return bl.GetAllEmp();
        }

        // GET: api/Employee/5
        public Employee Get(int id)
        {
            return bl.GetEmp(id);
        }

        // POST: api/Employee
        public string Post(Employee e)
        {
            bl.AddEmp(e);
            return "Created";
        }

        // PUT: api/Employee/5
        public string Put(int id, Employee e)
        {
            bl.UpdateEmp(id, e);
            return "Updated";
        }

        // DELETE: api/Employee/5
        public string Delete(int id)
        {
            bl.DeleteEmp(id);
            return "Deleted";
        }
    }
}
