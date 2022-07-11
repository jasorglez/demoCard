using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EndavaContext : DbContext 
    {
        public DbSet<UsersEntity> Users { get; set; }
        public DbSet<DepartamentsEntity> Departaments { get; set; }
        public DbSet<CompanysEntity> Companys { get; set; }
        public DbSet<CampaignsEntity> Campaigns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=ic10.database.windows.net; Database=EndavaTest;User Id=jsoriano; Password=Qpzm1984");
            }
        }

    }
}
