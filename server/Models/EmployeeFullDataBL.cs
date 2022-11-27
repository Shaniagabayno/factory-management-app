using Elasticsearch.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class EmployeeFullDataBL
    {
        FactoryDBEntities2 db = new FactoryDBEntities2();

        public List<EmployeeFullData> GetFullData()
        {
            List<EmployeeFullData> employees = new List<EmployeeFullData>();
            foreach (var e in db.Employee)
            {
                EmployeeFullData empData = new EmployeeFullData();
                empData.Id = e.Id;
                empData.FirstName = e.FirstName;
                empData.LastName = e.LastName;
                empData.HireDate = e.HireDate;
                empData.Contact = e.Contact;
                empData.DepID = e.DepID;
                empData.Shifts = new List<Shifts>();

                var dep = db.Department.Where(x => x.Id == e.DepID).First();
                if (dep != null)
                {
                    empData.DepName = dep.DepName;
                }

                var empshift = db.EmployeeShift.Where(x => x.EmpID == e.Id).ToList();
                foreach (var empId in empshift)
                {
                    if (empId != null)
                    {
                        var shift = db.Shifts.Where(x => x.ID == empId.ShiftID).ToList();
                        foreach (var item in shift)
                        {
                            empData.Shifts.Add(item);

                        }
                    }
                }
                employees.Add(empData);
            }
            return employees;
        }


        public EmployeeFullData GetEmp(int id)
        {
             var emp = db.Employee.Where(x => x.Id == id).First();
            EmployeeFullData Emp = new EmployeeFullData();
            Emp.Id = emp.Id;
            Emp.FirstName = emp.FirstName;
            Emp.LastName = emp.LastName;
            Emp.HireDate = emp.HireDate;
            Emp.Contact = emp.Contact;
            Emp.DepID = emp.DepID;
            Emp.Shifts = new List<Shifts>();


            var dep = db.Department.Where(x => x.Id == Emp.DepID).First();
            if (dep != null)
            {
                Emp.DepName = dep.DepName;
            }

            var empshift = db.EmployeeShift.Where(x => x.EmpID == emp.Id).ToList();
            foreach (var empId in empshift)
            {
                if (empshift != null)
                {
                    var shift = db.Shifts.Where(x => x.ID == empId.ShiftID).ToList();
                    foreach (var item in shift)
                    {
                        Emp.Shifts.Add(item);
                    }
                }
            }

            return Emp;
        }

        //לפי הקריאה לפונצקיה ככה נקבל את כל המידע
        public List<EmployeeFullData> GetEmpNameorDep(string text)
        {

            if (text == null)
            {
                return GetFullData();
            }
            return GetFullData().Where(x => x.FirstName.StartsWith(text, StringComparison.InvariantCultureIgnoreCase) || x.LastName.StartsWith(text, StringComparison.InvariantCultureIgnoreCase) || x.DepName.StartsWith(text, StringComparison.InvariantCultureIgnoreCase)).ToList();

        }

    }
    }

