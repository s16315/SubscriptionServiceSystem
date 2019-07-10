namespace SubscriptionServiceApi.Infrastructure.Models
{
    public class InvoiceData : Entity
    {
        public string CustomerName { get; set; }
        public string Organization { get; set; }
        public string TaxNumber { get; set; }
        public string PaymentMethod { get; set; }
        public Address Address { get; set; }
    }
}