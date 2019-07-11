namespace SubscriptionServiceApi.ViewModels
{
    public class PersonViewModel : ViewModel
    {
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public AddressViewModel Address { get; set; }
        public InvoiceDataViewModel Invoice { get; set; }
    }
}