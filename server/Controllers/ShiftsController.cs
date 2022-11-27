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
    public class ShiftsController : ApiController
    {
        static ShiftBL bl = new ShiftBL();
        // GET: api/Shifts
        public IEnumerable<Shifts> Get()
        {
            return bl.ShiftsData();
        }

        // GET: api/Shifts/5
        public Shifts Get(int id)
        {
            return bl.GetShift(id);
        }

        // POST: api/Shifts
        public string Post(Shifts s)
        {
            bl.AddShift(s);
            return " Created";
        }

        // PUT: api/Shifts/5
        public string Put(int id, Shifts s)
        {
            bl.UpdateShift(id, s);
            return "Updated";
        }

        // DELETE: api/Shifts/5
        public string Delete(int id)
        {
            bl.DeleteShift(id);
            return "Deleted";
        }
    }
}
