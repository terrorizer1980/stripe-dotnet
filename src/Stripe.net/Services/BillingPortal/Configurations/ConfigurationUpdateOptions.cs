// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class ConfigurationUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Whether the configuration is active and can be used to create portal sessions.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// The business information shown to customers in the portal.
        /// </summary>
        [JsonProperty("business_profile")]
        public ConfigurationBusinessProfileOptions BusinessProfile { get; set; }

        /// <summary>
        /// The default url to redirect customers after they manage their account. This can also be
        /// overriden in the session.
        /// </summary>
        [JsonProperty("default_return_url")]
        public string DefaultReturnUrl { get; set; }

        /// <summary>
        /// Information about the features that will be shown in the portal.
        /// </summary>
        [JsonProperty("features")]
        public ConfigurationFeaturesOptions Features { get; set; }
    }
}
