using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace Project1.Models
{

    public class UserBL
    {
        FactoryDBEntities2  db = new FactoryDBEntities2();

        public List<User> GetAllUser()
        {
            return db.User.ToList();
        }

        public User GetUser(int id)
        {
            return db.User.Where(x => x.Id == id).First();
        }

        public User GetuserNameorPass(string userName ,string Password)
        {
            return db.User.Where(x=> x.UserName == userName && x.Password == Password).FirstOrDefault();
           
        }

     
    
            public void AddUser(User u)
        {
            db.User.Add(u);
            db.SaveChanges();
        }

        public void UpdateUser(int id, User u)
        {
           
            var userNew = db.User.Where(x => x.Id == id).First();
            userNew.FullName = u.FullName;
            userNew.UserName = u.UserName;
            userNew.Password = u.Password;
            userNew.MaxActions = u.MaxActions;
            userNew.TotalActionsToday = u.TotalActionsToday;
          var todayDate = DateTime.Now;

            if (userNew.LastLogin.Date.ToShortDateString() != todayDate.Date.ToShortDateString())
                {
                    userNew.TotalActionsToday = 0;
                    userNew.LastLogin = todayDate;
              
              }
              db.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = db.User.Where(x => x.Id == id).First();
            db.User.Remove(user);
            db.SaveChanges();
        }
    }
}