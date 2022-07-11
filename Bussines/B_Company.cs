using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
    public class B_Company
    {
            public static List<CompanysEntity> CompanyList()
            {
                using (var db = new EndavaContext())
                {
                    return db.Companys.Where(c=>c.Active==true).ToList();
                }
            }

            public static CompanysEntity CompanyById(int id)
            {
                using (var db = new EndavaContext())
                {
                    return db.Companys.ToList().LastOrDefault(d => d.CompanyId == id);
                }
            }


        public static void CreateCompany(CompanysEntity oCompany)
            {
                using (var db = new EndavaContext())
                {
                    oCompany.Active = true;
                    db.Companys.Add(oCompany);
                    db.SaveChanges();
                }
            }

            public static void UpdateCompany(CompanysEntity oCompany)
            {
                using (var db = new EndavaContext())
                {
                    db.Companys.Update(oCompany);
                    db.SaveChanges();
                }
            }

        public static void DeleteById(CompanysEntity comp)
        {
            using (var db = new EndavaContext())
            {
                comp.Active = false;
                db.Companys.Update(comp);
                db.SaveChanges();
            }
        }

    }
}
