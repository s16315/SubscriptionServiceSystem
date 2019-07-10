using System.Collections.Generic;

namespace SubscriptionServiceApi.Infrastructure.Models
{
    public class User : Entity
    {
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public Person Person { get; set; }
        public IEnumerable<Subscription> Subscriptions { get; set; }

    }
}