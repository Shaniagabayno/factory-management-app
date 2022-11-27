using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class EmployeeShiftBL
    {
        FactoryDBEntities2 db = new FactoryDBEntities2();

        public List<EmployeeShift> GetData()
        {
            return db.EmployeeShift.ToList();
        }

        public EmployeeShift GetEmpShift(int id)
        {
            return db.EmployeeShift.Where(x => x.Id == id).First();
        }

        public void AddEmpShift(EmployeeShift empS)
        {
            db.EmployeeShift.Add(empS);
            db.SaveChanges();
        }

        public void UpdateEmpShift(int id, EmployeeShift empS)
        {
            var updEmpshift = db.EmployeeShift.Where(x => x.Id == id).First();
            updEmpshift.EmpID = empS.EmpID;
            updEmpshift.ShiftID = empS.ShiftID;
            db.SaveChanges();
        }

        public void DeleteEmpShift(int id)
        {
            var es = db.EmployeeShift.Where(x => x.Id == id || x.EmpID == id).First();
            db.EmployeeShift.Remove(es);
            db.SaveChanges();
            
        }

       
    }
}