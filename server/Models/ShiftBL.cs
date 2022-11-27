using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class ShiftBL
    {
        FactoryDBEntities2 db = new FactoryDBEntities2();

        public List<Shifts> ShiftsData()
        {
            return db.Shifts.ToList();
        }

        public Shifts GetShift(int id)
        {
            return db.Shifts.Where(x => x.ID == id).First();
        }

        public void AddShift(Shifts s)
        {
            db.Shifts.Add(s);
            db.SaveChanges();
        }

        public void UpdateShift(int id, Shifts s)
        {
            var updShift = db.Shifts.Where(x => x.ID == id).First();
            updShift.Date = s.Date;
            updShift.StartTime = s.StartTime;
            updShift.EndTime = s.EndTime;
            db.SaveChanges();
        }

        public void DeleteShift(int id)
        {
            var shift = db.Shifts.Where(x => x.ID == id).First();
            db.Shifts.Remove(shift);
            db.SaveChanges();
        }
    }
}