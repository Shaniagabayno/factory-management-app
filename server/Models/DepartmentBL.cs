using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class DepartmentBL
    {
        FactoryDBEntities2 db = new FactoryDBEntities2();

        public List<Department> GetAllDep()
        {
            return db.Department.ToList();
        }

        public Department GetDep(int id)
        {
            return db.Department.Where(x => x.Id == id).First();
        }

        public void AddDep(Department d)
        {
            db.Department.Add(d);
            db.SaveChanges();
        }

        public void UpdateDep(int id, Department d)
        {
            var dep = db.Department.Where(x => x.Id == id).First();
            dep.DepName = d.DepName;
            dep.Manager = d.Manager;
            db.SaveChanges();
        }

        public void DeleteDep(int id)
        {
            var department = db.Department.Where(x => x.Id == id).First();
            db.Department.Remove(department);
            db.SaveChanges();
        }
    }
}