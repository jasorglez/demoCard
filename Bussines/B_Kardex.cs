using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class B_Kardex 
    {
    
        public static void CreateKardex(KardexEntity kardex, string mensaje1, string mensaje2, string numtra, string mensaje4)
        {
            using (var db = new EndavaContext())
            { 
             
 
               kardex.fecha = DateTime.Now.ToString();
               kardex.hora = DateTime.Now.ToString("HH:mm:ss");
               kardex.userId = 5;
               kardex.card = mensaje1;
               kardex.transaccion = numtra;
               kardex.transaccion2 = mensaje2;
               kardex.transaccion3 = mensaje4;
                kardex.Active = true;
               db.Kardex.Add(kardex);
               db.SaveChanges();
            }
        }

        public static List<KardexEntity> kardexList()
        {
            using (var db = new EndavaContext())
            {

                 return db.Kardex.Where(k => k.Active == true)
                    .OrderByDescending(k => k.Id)
                    .ToList();
            }
        }

        public static void CancelKardex(KardexEntity kardex)
        {
            using (var db = new EndavaContext())
            {          
                db.Kardex.Remove(kardex);   
            }
        }

    }

}
