using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class B_Users
    {
        public static List<UsersEntity> UsersList()
        {
            using (var db = new EndavaContext())
            {
                return db.Users.ToList();
            }
        }

        public static UsersEntity UserById(int id)
        {
            using (var db = new EndavaContext())
            {
                return db.Users.ToList().LastOrDefault(u => u.UserId == id);
            }
        }

        public static void CreateUser(UsersEntity oUser)
        {
            using (var db = new EndavaContext())
            {

                db.Users.Add(oUser);
                db.SaveChanges();
            }
        }

        public static void UpdateUser(UsersEntity oUser)
        {
            using (var db = new EndavaContext())
            {
                db.Users.Update(oUser);
                db.SaveChanges();
            }
        }
    }
}
