using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class EmployeeFullData
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime HireDate { get; set; }
        public string Contact { get; set; }
        public int DepID { get; set; }
        public string DepName { get; set; }
        

        public List<Shifts> Shifts { get; set; }





    }
}