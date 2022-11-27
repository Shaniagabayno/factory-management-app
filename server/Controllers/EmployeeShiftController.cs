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
    public class EmployeeShiftController : ApiController
    {
        static EmployeeShiftBL bl = new EmployeeShiftBL();
        // GET: api/EmployeeShift
        public IEnumerable<EmployeeShift> Get()
        {
            return bl.GetData();
        }

        // GET: api/EmployeeShift/5
        public EmployeeShift Get(int id)
        {
            return bl.GetEmpShift(id);
        }

       

        // POST: api/EmployeeShift
        public string Post(EmployeeShift empS)
        {
            bl.AddEmpShift(empS);
            return "Created";

        }

        // PUT: api/EmployeeShift/5
        public string Put(int id, EmployeeShift empS)
        {
            bl.UpdateEmpShift(id, empS);
            return "Updated";
        }

        // DELETE: api/EmployeeShift/5
        public string Delete(int id)
        {
            bl.DeleteEmpShift(id);
           
            return "Deleted";
        }


       
    }
}
