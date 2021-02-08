// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// The configuration to use in the portal.
        /// </summary>
        [JsonProperty("configuration")]
        public string Configuration { get; set; }

        /// <summary>
        /// The ID of an existing customer.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The <c>on_behalf_of</c> to use in the portal. When specified, only subscriptions and
        /// invoices with this <c>on_behalf_of</c> will appear. For more information, see the <a
        /// href="https://stripe.com/docs/connect/charges-transfers#on-behalf-of">docs</a>.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// The URL to which Stripe should send customers when they click on the link to return to
        /// your website. This field is required if a default return URL has not been configured for
        /// the portal.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}
