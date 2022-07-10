using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class B_Departaments
    {
        public static List<DepartamentsEntity> DepartamentList()
        {
            using (var db = new EndavaContext())
            {
                return db.Departaments.ToList();
            }
        }


        public static void CreateDepartament(DepartamentsEntity oDepartam)
        {
            using (var db = new EndavaContext())
            {
                db.Departaments.Add(oDepartam);
                db.SaveChanges();
            }
        }

        public static void UpdateDepartament(DepartamentsEntity oDepartament)
        {
            using (var db = new EndavaContext())
            {
                db.Departaments.Update(oDepartament);
                db.SaveChanges();
            }
        }
    }
}
