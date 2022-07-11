using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines
{
   public class B_Campaigns
    {
        public static List<CampaignsEntity> CampaignList()
        {
            using (var db = new EndavaContext())
            {
                return db.Campaigns.Where(ca => ca.Active==true).ToList();
            }
        }

        public static CampaignsEntity CampaignById(int id)
        {
            using (var db = new EndavaContext())
            {
                return db.Campaigns.ToList().LastOrDefault(d => d.CampaignId == id);
            }
        }

        public static void CreateCampaign(CampaignsEntity oCampaign)
        {
            using (var db = new EndavaContext())
            {
                oCampaign.Active = true;
                db.Campaigns.Add(oCampaign);
                db.SaveChanges();
            }
        }

        public static void UpdateCampaign(CampaignsEntity oCampaign)
        {
            using (var db = new EndavaContext())
            {
                db.Campaigns.Update(oCampaign);
                db.SaveChanges();
            }
        }

        public static void DeleteById(CampaignsEntity campa)
        {
            using (var db = new EndavaContext())
            {
                campa.Active = false;
                db.Campaigns.Update(campa);
                db.SaveChanges();
            }
        }
    }
}
