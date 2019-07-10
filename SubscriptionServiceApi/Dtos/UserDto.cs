using System.Collections.Generic;
using SubscriptionServiceApi.Infrastructure.Models;

namespace SubscriptionServiceApi.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        public InvoiceData Invoice { get; set; }
        public IEnumerable<Subscription> Subscriptions { get; set; }
        
        
    }
}