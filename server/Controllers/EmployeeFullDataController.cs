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
    public class EmployeeFullDataController : ApiController
    {
        EmployeeFullDataBL bl = new EmployeeFullDataBL();
        // GET: api/EmployeeFullData
        public IEnumerable<EmployeeFullData> Get()
        {
            return bl.GetFullData();
        }

        // GET: api/EmployeeFullData/5
        public EmployeeFullData Get(int id)
        {
            return bl.GetEmp(id);
        }
        //חשוב לשים בפרטמר את שם שמ
        public IEnumerable<EmployeeFullData> GetByName(string text)
        {
            return bl.GetEmpNameorDep(text );
        }
        



        // POST: api/EmployeeFullData
        public void Post(int id, [FromBody] string value)
        {
           
        }

        // PUT: api/EmployeeFullData/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/EmployeeFullData/5
        public void Delete(int id)
        {
        }
    }
}
