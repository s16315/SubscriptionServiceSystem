namespace SubscriptionServiceApi.Infrastructure.Models
{
    public class Person : Entity
    {
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        public InvoiceData Invoice { get; set; }        
    }
}