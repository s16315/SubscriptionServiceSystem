using System.Collections.Generic;

namespace SubscriptionServiceApi.ViewModels
{
    public class UserViewModel : ViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public PersonViewModel Person { get; set; }
        public IEnumerable<SubscriptionViewModel> Subscriptions { get; set; }
    }
}