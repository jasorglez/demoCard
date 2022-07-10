using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Transactionsbycard
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Acquirer
        {
            public string institution_id_code { get; set; }
            public string retrieval_reference_number { get; set; }
            public string system_trace_audit_number { get; set; }
        }

        public class Balances
        {
            public USD USD { get; set; }
        }

        public class Card
        {
            public string last_four { get; set; }
            public Metadata metadata { get; set; }
        }

        public class CardAcceptor
        {
            public string mid { get; set; }
            public string mcc { get; set; }
            public string name { get; set; }
            public string street_address { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string postal_code { get; set; }
            public string country_code { get; set; }
        }

        public class CurrencyConversion
        {
            public Network network { get; set; }
        }

        public class Datum
        {
            public string type { get; set; }
            public string state { get; set; }
            public string identifier { get; set; }
            public string token { get; set; }
            public string user_token { get; set; }
            public string acting_user_token { get; set; }
            public string card_token { get; set; }
            public string card_product_token { get; set; }
            public Gpa gpa { get; set; }
            public int duration { get; set; }
            public DateTime created_time { get; set; }
            public DateTime user_transaction_time { get; set; }
            public double request_amount { get; set; }
            public double amount { get; set; }
            public CurrencyConversion currency_conversion { get; set; }
            public string currency_code { get; set; }
            public string approval_code { get; set; }
            public Response response { get; set; }
            public string network { get; set; }
            public int acquirer_fee_amount { get; set; }
            public Acquirer acquirer { get; set; }
            public User user { get; set; }
            public Card card { get; set; }
            public DateTime issuer_received_time { get; set; }
            public string issuer_payment_node { get; set; }
            public CardAcceptor card_acceptor { get; set; }
            public Pos pos { get; set; }
            public DateTime? settlement_date { get; set; }
            public string network_reference_id { get; set; }
            public string preceding_related_transaction_token { get; set; }
            public GpaOrder gpa_order { get; set; }
            public string subnetwork { get; set; }
        }

        public class Funding
        {
            public double amount { get; set; }
            public Source source { get; set; }
        }

        public class Gpa
        {
            public string currency_code { get; set; }
            public double ledger_balance { get; set; }
            public double available_balance { get; set; }
            public double credit_balance { get; set; }
            public double pending_credits { get; set; }
            public double impacted_amount { get; set; }
            public Balances balances { get; set; }
        }

        public class GpaOrder
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

        public class Metadata
        {
        }

        public class Network
        {
            public SettlementData settlement_data { get; set; }
        }

        public class Pos
        {
            public string terminal_id { get; set; }
            public bool pin_present { get; set; }
            public bool partial_approval_capable { get; set; }
            public bool purchase_amount_only { get; set; }
            public bool is_recurring { get; set; }
            public bool is_installment { get; set; }
        }

        public class Response
        {
            public string code { get; set; }
            public string memo { get; set; }
        }

        public class Root
        {
            public int count { get; set; }
            public int start_index { get; set; }
            public int end_index { get; set; }
            public bool is_more { get; set; }
            public List<Datum> data { get; set; }
            public List<GpaOrder> orders { get; set; }
        }

        public class SettlementData
        {
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

        public class USD
        {
            public string currency_code { get; set; }
            public double ledger_balance { get; set; }
            public double available_balance { get; set; }
            public double credit_balance { get; set; }
            public double pending_credits { get; set; }
            public double impacted_amount { get; set; }
        }

        public class User
        {
            public Metadata metadata { get; set; }
        }

    }
}
