using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class EmployeeBL
    {
        FactoryDBEntities2 db = new FactoryDBEntities2();

        public List<Employee> GetAllEmp()
        {
            return db.Employee.ToList();
        }

        public Employee GetEmp(int id)
        {
            return db.Employee.Where(x => x.Id == id).First();
        }

        public void AddEmp(Employee e)
        {
            db.Employee.Add(e);
            db.SaveChanges();
        }

        public void UpdateEmp(int id, Employee e)
        {
            var updEmp = db.Employee.Where(x => x.Id == id).First();
            updEmp.FirstName = e.FirstName;
            updEmp.LastName = e.LastName;
            updEmp.HireDate = e.HireDate;
            updEmp.DepID = e.DepID;
            db.SaveChanges();
        }

        public void DeleteEmp(int id)
        {
            var emp = db.Employee.Where(x => x.Id == id).First();
            db.Employee.Remove(emp);
            db.SaveChanges();
        }
    }
}