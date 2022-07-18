using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
   public class Deposit
    {
        public class Funding
        {
            public double amount { get; set; }
            public Source source { get; set; }
        }

        public class Response
        {
            public string code { get; set; }
            public string memo { get; set; }
        }

        public class Root
        {
            public string token { get; set; }
            public double amount { get; set; }
            public DateTime created_time { get; set; }
            public DateTime last_modified_time { get; set; }
            public string transaction_token { get; set; }
            public string state { get; set; }
            public Response response { get; set; }
            public Funding funding { get; set; }
            public string funding_source_token { get; set; }
            public string user_token { get; set; }
            public string currency_code { get; set; }
        }

        public class Source
        {
            public string type { get; set; }
            public string token { get; set; }
            public string name { get; set; }
            public bool active { get; set; }
            public bool is_default_account { get; set; }
            public DateTime created_time { get; set; }
            public DateTime last_modified_time { get; set; }
        }
    }
   


}
