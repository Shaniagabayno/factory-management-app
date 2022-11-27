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
    public class DepartmentController : ApiController
    {
        DepartmentBL bl = new DepartmentBL();
        // GET: api/Department
        public IEnumerable<Department> Get()
        {
            return bl.GetAllDep();
        }

        // GET: api/Department/5
        public Department Get(int id)
        {
            return bl.GetDep(id);
        }

        // POST: api/Department
        public string Post(Department d)
        {
            bl.AddDep(d);
            return "Created";
        }

        // PUT: api/Department/5
        public string Put(int id, Department d)
        {
            bl.UpdateDep(id, d);
            return "Updated";
        }

        // DELETE: api/Department/5
        public string Delete(int id)
        {
            bl.DeleteDep(id);
            return "Deleted";
        }
    }
}
