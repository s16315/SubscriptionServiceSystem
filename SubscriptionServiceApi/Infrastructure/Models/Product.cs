using System.Collections.Generic;

namespace SubscriptionServiceApi.Infrastructure.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public float Prince { get; set; }
        public float UpgradePrince { get; set; }
        public Discount Discount { get; set; }
        public IEnumerable<Subscription> Subscriptions { get;}
    }
}