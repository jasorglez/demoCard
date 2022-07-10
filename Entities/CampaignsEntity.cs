using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
        public partial class CampaignsEntity
        {
            [Key]
            public int CampaignId { get; set; }
            public string? Name { get; set; }
            public string? Description { get; set; }
            public string Add1 { get; set; }
            public string Add2 { get; set; }
            public int CompanyId { get; set; }
            public bool? Active { get; set; }
           //  public virtual CompanysEntity IdCompanyNavigation { get; set; } = null!;
            public virtual CompanysEntity Company { get; set; } = null!;
    }
}
