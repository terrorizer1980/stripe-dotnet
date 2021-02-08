namespace StripeTests.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.BillingPortal;
    using Xunit;

    public class ConfigurationTest : BaseStripeTest
    {
        public ConfigurationTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.billing_portal.cfg.json");
            var cfg = JsonConvert.DeserializeObject<Configuration>(json);
            Assert.NotNull(cfg);
            Assert.IsType<Configuration>(cfg);
            Assert.NotNull(cfg.Id);
            Assert.Equal("billing_portal.cfg", cfg.Object);
        }
    }
}
