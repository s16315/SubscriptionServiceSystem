using System;

namespace SubscriptionServiceApi.Infrastructure.Models
{
    public class Subscription : Entity
    {
        public User User { get; set; }
        public Product Product { get; set; }
        public ProductVersion ProductVersion { get; set; }
        public DateTime SubscriptionStartTime { get; set; }
        public DateTime SubscriptionEndTime { get; set; }
        public bool IsPaid { get; set; }
        public bool DemoAvailable { get; set; }
        public DateTime DemoStartTime { get; set; }
        public DateTime DemoEndTime { get; set; }        
    }
}