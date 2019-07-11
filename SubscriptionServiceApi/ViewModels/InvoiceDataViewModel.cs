namespace SubscriptionServiceApi.ViewModels
{
    public class InvoiceDataViewModel : ViewModel
    {
        public string CustomerName { get; set; }
        public string Organization { get; set; }
        public string TaxNumber { get; set; }
        public string PaymentMethod { get; set; }
        public AddressViewModel Address { get; set; }
    }
}