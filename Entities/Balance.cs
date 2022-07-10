using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Balance
    {
       
            // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
            public class Balances
            {
                public USD USD { get; set; }
            }

            public class Gpa
            {
                public string currency_code { get; set; }
                public double ledger_balance { get; set; }
                public double available_balance { get; set; }
                public double credit_balance { get; set; }
                public double pending_credits { get; set; }
                public Balances balances { get; set; }
            }

            public class balancetotal
            {
                public Gpa gpa { get; set; }
            }

            public class USD
            {
                public string currency_code { get; set; }
                public double ledger_balance { get; set; }
                public double available_balance { get; set; }
                public double credit_balance { get; set; }
                public double pending_credits { get; set; }
            }

        }
    }
