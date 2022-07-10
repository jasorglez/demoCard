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
        [Required(ErrorMessage = "* Obligatorio")]
        public string? Name { get; set; }
        public string? Adress { get; set; }
        [Required(ErrorMessage = "* Obligatorio")]
        public string? Cp { get; set; }
        [Required(ErrorMessage = "* Obligatorio")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "* Obligatorio")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "* Obligatorio")]
        public string? Web { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<CampaignsEntity> Campaigns { get; set; }
        public virtual ICollection<UsersEntity> Users { get; set; }
    }
}
