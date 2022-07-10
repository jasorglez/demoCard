using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cardproducts
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class AddressVerification
        {
            public AvMessages av_messages { get; set; }
            public AuthMessages auth_messages { get; set; }
            public bool validate { get; set; }
        }

        public class AuthMessages
        {
            public bool validate { get; set; }
            public bool decline_on_address_number_mismatch { get; set; }
            public bool decline_on_postal_code_mismatch { get; set; }
        }

        public class AvMessages
        {
            public bool validate { get; set; }
            public bool decline_on_address_number_mismatch { get; set; }
            public bool decline_on_postal_code_mismatch { get; set; }
        }

        public class CardLifeCycle
        {
            public bool activate_upon_issue { get; set; }
            public ExpirationOffset expiration_offset { get; set; }
            public int card_service_code { get; set; }
            public bool update_expiration_upon_activation { get; set; }
        }

        public class ClearingAndSettlement
        {
            public string overdraft_destination { get; set; }
        }

        public class Config
        {
            public Poi poi { get; set; }
            public TransactionControls transaction_controls { get; set; }
            public SelectiveAuth selective_auth { get; set; }
            public Special special { get; set; }
            public CardLifeCycle card_life_cycle { get; set; }
            public ClearingAndSettlement clearing_and_settlement { get; set; }
            public JitFunding jit_funding { get; set; }
            public DigitalWalletTokenization digital_wallet_tokenization { get; set; }
            public Fulfillment fulfillment { get; set; }
        }

        public class Datum
        {
            public string token { get; set; }
            public string name { get; set; }
            public bool active { get; set; }
            public string start_date { get; set; }
            public Config config { get; set; }
            public DateTime created_time { get; set; }
            public DateTime last_modified_time { get; set; }
        }

        public class DigitalWalletTokenization
        {
            public ProvisioningControls provisioning_controls { get; set; }
            public string card_art_id { get; set; }
        }

        public class ExpirationOffset
        {
            public string unit { get; set; }
            public int value { get; set; }
        }

        public class Fulfillment
        {
            public string payment_instrument { get; set; }
            public string package_id { get; set; }
            public bool all_zero_card_security_code { get; set; }
            public string bin_prefix { get; set; }
            public bool bulk_ship { get; set; }
            public string pan_length { get; set; }
            public string fulfillment_provider { get; set; }
            public bool allow_card_creation { get; set; }
            public bool uppercase_name_lines { get; set; }
            public bool enable_offline_pin { get; set; }
        }

        public class InAppProvisioning
        {
            public bool enabled { get; set; }
            public AddressVerification address_verification { get; set; }
        }

        public class JitFunding
        {
            public PaymentcardFundingSource paymentcard_funding_source { get; set; }
            public ProgramgatewayFundingSource programgateway_funding_source { get; set; }
            public ProgramFundingSource program_funding_source { get; set; }
        }

        public class ManualEntry
        {
            public bool enabled { get; set; }
            public AddressVerification address_verification { get; set; }
        }

        public class Other
        {
            public bool allow { get; set; }
            public bool card_presence_required { get; set; }
            public bool cardholder_presence_required { get; set; }
            public string track1_discretionary_data { get; set; }
            public string track2_discretionary_data { get; set; }
        }

        public class PaymentcardFundingSource
        {
            public bool enabled { get; set; }
            public string refunds_destination { get; set; }
        }

        public class Poi
        {
            public Other other { get; set; }
            public bool ecommerce { get; set; }
            public bool atm { get; set; }
        }

        public class ProgramFundingSource
        {
            public bool enabled { get; set; }
            public string funding_source_token { get; set; }
            public string refunds_destination { get; set; }
        }

        public class ProgramgatewayFundingSource
        {
            public bool enabled { get; set; }
            public string funding_source_token { get; set; }
            public string refunds_destination { get; set; }
            public bool always_fund { get; set; }
        }

        public class ProvisioningControls
        {
            public ManualEntry manual_entry { get; set; }
            public WalletProviderCardOnFile wallet_provider_card_on_file { get; set; }
            public InAppProvisioning in_app_provisioning { get; set; }
            public WebPushProvisioning web_push_provisioning { get; set; }
        }

        public class Root1
        {
            public int count { get; set; }
            public int start_index { get; set; }
            public int end_index { get; set; }
            public bool is_more { get; set; }
            public List<Datum> data { get; set; }
        }

        public class SelectiveAuth
        {
            public int sa_mode { get; set; }
            public bool enable_regex_search_chain { get; set; }
            public int dmd_location_sensitivity { get; set; }
        }

        public class Special
        {
            public bool merchant_on_boarding { get; set; }
        }

        public class StrongCustomerAuthenticationLimits
        {
        }

        public class TransactionControls
        {
            public string accepted_countries_token { get; set; }
            public bool always_require_pin { get; set; }
            public bool always_require_icc { get; set; }
            public bool allow_gpa_auth { get; set; }
            public bool require_card_not_present_card_security_code { get; set; }
            public bool allow_mcc_group_authorization_controls { get; set; }
            public bool allow_first_pin_set_via_financial_transaction { get; set; }
            public bool ignore_card_suspended_state { get; set; }
            public bool allow_chip_fallback { get; set; }
            public bool allow_network_load { get; set; }
            public bool allow_network_load_card_activation { get; set; }
            public bool allow_quasi_cash { get; set; }
            public bool enable_partial_auth_approval { get; set; }
            public AddressVerification address_verification { get; set; }
            public StrongCustomerAuthenticationLimits strong_customer_authentication_limits { get; set; }
            public string quasi_cash_exempt_mids { get; set; }
            public bool enable_credit_service { get; set; }
        }

        public class WalletProviderCardOnFile
        {
            public bool enabled { get; set; }
            public AddressVerification address_verification { get; set; }
        }

        public class WebPushProvisioning
        {
            public string wpp_apple_partner_id { get; set; }
            public string wpp_apple_card_template_id { get; set; }
            public string wpp_google_piaid { get; set; }
        }


    }
}
