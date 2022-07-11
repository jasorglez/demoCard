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
                return db.Departaments.Where(d =>d.Active==true).ToList();
            }
        }
        
        public static DepartamentsEntity DepartamentById(int id)
        {
            using (var db = new EndavaContext())
            {
                return db.Departaments.ToList().LastOrDefault(u => u.DepartamentId == id);

            }
        }
   
        public static void CreateDepartament(DepartamentsEntity oDepartam)
        {
            using (var db = new EndavaContext())
            {
                oDepartam.Active = true;
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

        public static void DeleteById(DepartamentsEntity dep)
        {
            using (var db = new EndavaContext())
            {
                dep.Active = false;
                db.Departaments.Update(dep);
                db.SaveChanges();
            }
        }
    }
}
