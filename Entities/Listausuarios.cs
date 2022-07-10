using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Listausuarios
    {
        public class Datum
        {
            public string token { get; set; }
            public bool active { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string email { get; set; }
            public string address1 { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string postal_code { get; set; }
            public string country { get; set; }
            public string birth_date { get; set; }
            public bool uses_parent_account { get; set; }
            public bool corporate_card_holder { get; set; }
            public DateTime created_time { get; set; }
            public DateTime last_modified_time { get; set; }
            public Metadata metadata { get; set; }
            public string account_holder_group_token { get; set; }
            public string status { get; set; }
        }

        public class Metadata
        {
        }

        public class Root
        {
            public int count { get; set; }
            public int start_index { get; set; }
            public int end_index { get; set; }
            public bool is_more { get; set; }
            public List<Datum> data { get; set; }
        }
    }
}
