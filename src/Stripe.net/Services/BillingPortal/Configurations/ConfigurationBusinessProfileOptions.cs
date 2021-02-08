// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class ConfigurationBusinessProfileOptions : INestedOptions
    {
        /// <summary>
        /// The messaging shown to customers in the portal.
        /// </summary>
        [JsonProperty("headline")]
        public string Headline { get; set; }

        /// <summary>
        /// The privacy policy url shown to customers in the portal.
        /// </summary>
        [JsonProperty("privacy_policy_url")]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// The terms of service url shown to customers in the portal.
        /// </summary>
        [JsonProperty("terms_of_service_url")]
        public string TermsOfServiceUrl { get; set; }
    }
}
