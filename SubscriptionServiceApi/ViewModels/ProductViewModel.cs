using SubscriptionServiceApi.ViewModels;

namespace SubscriptionServiceApi.ViewModels
{
    public class ProductViewModel: ViewModel
    {
        public string Name { get; set; }
        public float Prince { get; set; }
        public float UpgradePrince { get; set; }
        public DiscountViewModel Discount { get; set; }
    }
}