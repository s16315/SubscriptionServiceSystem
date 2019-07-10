using SubscriptionServiceApi.Infrastructure;

namespace SubscriptionServiceApi.Infrastructure.Models
{
    public class Address : Entity
    {
        public string AddressCountry { get; set; }
        public string AddressLocality { get; set; }
        public string AddressRegion { get; set; }
        public string PostOfficeBoxNumber { get; set; }
        public string PostalCode { get; set; }
        public string PostalAddress { get; set; }
    }
}