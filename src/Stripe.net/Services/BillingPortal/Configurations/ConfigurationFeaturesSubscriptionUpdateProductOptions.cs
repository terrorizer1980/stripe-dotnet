// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ConfigurationFeaturesSubscriptionUpdateProductOptions : INestedOptions
    {
        /// <summary>
        /// The list of prices which, when subscribed to, a subscription can be updated.
        /// </summary>
        [JsonProperty("prices")]
        public List<string> Prices { get; set; }

        /// <summary>
        /// The product id.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }
    }
}
