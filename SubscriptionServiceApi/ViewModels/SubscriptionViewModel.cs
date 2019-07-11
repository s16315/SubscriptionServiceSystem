using System;

namespace SubscriptionServiceApi.ViewModels
{
    public class SubscriptionViewModel : ViewModel
    {
        public ProductViewModel Product { get; set; }
        public ProductVersionViewModel ProductVersion { get; set; }
        public DateTime SubscriptionStartTime { get; set; }
        public DateTime SubscriptionEndTime { get; set; }
        public bool IsPaid { get; set; }
        public bool DemoAvailable { get; set; }
        public DateTime DemoStartTime { get; set; }
        public DateTime DemoEndTime { get; set; }    
    }
}