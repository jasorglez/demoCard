using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CardEntity
    {
        public string userToken { get; set; }
        public Double Amount { get; set; }
        public string currency_code { get; set; }
        public string Founding_source { get; set; }
    }
}
