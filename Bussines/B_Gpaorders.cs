using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class B_Gpaorders
    {
        public static List<GpaordersEntity> gpaordersList()
        {
            using (var db = new EndavaContext())
            {
                return db.Gpaorders.Where(u => u.Active == true).ToList();
            }
        }

        public static GpaordersEntity gpaById(int id)
        {
            using (var db = new EndavaContext())
            {
                return db.Gpaorders.ToList().LastOrDefault(u => u.Id == id);

            }
        }

        public static void CreateGpa(GpaordersEntity gpao)
        {
            using (var db = new EndavaContext())
            {
                gpao.Active = true;
                db.Gpaorders.Add(gpao);
                db.SaveChanges();
            }
        }

        public static void UpdateGpa(GpaordersEntity Gpa)
        {
            using (var db = new EndavaContext())
            {
                
                db.Gpaorders.Update(Gpa);
                db.SaveChanges();
            }
        }

        public static void DeleteById(GpaordersEntity Gpa)
        {
            using (var db = new EndavaContext())
            {
                Gpa.Active = false;
                db.Gpaorders.Update(Gpa);
                db.SaveChanges();
            }
        }

        public static void Cancelar(GpaordersEntity Gpa)
        {
            using (var db = new EndavaContext())
            {
                db.Gpaorders.Remove(Gpa);
            }
        }



    }
}
