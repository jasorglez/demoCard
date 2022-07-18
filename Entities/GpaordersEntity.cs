using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class GpaordersEntity
    {
        public int Id { get; set; }
        public string fecha { get; set; } = DateTime.Now.ToString("mm/dd/yyyy");
        public string user_token { get; set; } = "jsoriano";
        public Decimal amount { get; set; } = 0;
        public string? currencycode { get; set; } = "USD";
        public string fundingsource { get; set; } = "sandbox_program_funding";
        public bool Active { get; set; }
    }
}
