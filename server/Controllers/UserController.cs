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
    public class UserController : ApiController
    {
        static UserBL bl = new UserBL();
        // GET: api/User
        public IEnumerable<User> Get()
        {
            return bl.GetAllUser();
        }

        // GET: api/User/5
        public User Get(int id)
        {
            return bl.GetUser(id);
        }

        public User GetBysearch(string userName ,string Password)
        {
            return bl.GetuserNameorPass(userName, Password);
        }

        // POST: api/User
        public string Post(User u)
        {
            bl.AddUser(u);
            return "Created";
        }

        // PUT: api/User/5
        public string Put(int id, User u)
        {
            bl.UpdateUser(id, u);
            return "Updated";
        }

      

        // DELETE: api/User/5
        public string Delete(int id)
        {
            bl.DeleteUser(id);
            return "Deleted";
        }
    }
}
