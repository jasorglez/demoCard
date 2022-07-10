using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Getcardforuser
    {
       
            // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
            public class Datum
            {
                public DateTime created_time { get; set; }
                public DateTime last_modified_time { get; set; }
                public string token { get; set; }
                public string user_token { get; set; }
                public string card_product_token { get; set; }
                public string last_four { get; set; }
                public string pan { get; set; }
                public string expiration { get; set; }
                public DateTime expiration_time { get; set; }
                public string barcode { get; set; }
                public bool pin_is_set { get; set; }
                public string state { get; set; }
                public string state_reason { get; set; }
                public string fulfillment_status { get; set; }
                public string instrument_type { get; set; }
                public bool expedite { get; set; }
                public Metadata metadata { get; set; }
            }

            public class Metadata
            {
            }

            public class Users
            {
                public int count { get; set; }
                public int start_index { get; set; }
                public int end_index { get; set; }
                public bool is_more { get; set; }
                public List<Datum> data { get; set; }
            }


        }
    }
