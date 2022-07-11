using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CompanysEntity
    {
        public CompanysEntity()
        {
            Campaigns = new HashSet<CampaignsEntity>();
            Users = new HashSet<UsersEntity>();
        }
        [Key]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Name Required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Adress Required")]
        public string? Adress { get; set; }
       
        [Required(ErrorMessage = "Cp Required")]
        public string? Cp { get; set; }

        [Phone]
        [Required(ErrorMessage = "Phone Required")]
        public string? Phone { get; set; }
       
        [EmailAddress]
        [Required(ErrorMessage = "Email Required")]
        public string? Email { get; set; }
      
        [Url]
        public string? Web { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<CampaignsEntity> Campaigns { get; set; }
        public virtual ICollection<UsersEntity> Users { get; set; }
    }
}
