namespace SubscriptionServiceApi.Infrastructure.Models{
    public class Discount : Entity
    {
        public short Monthly { get; set; }
        public short HalfYear { get; set; }
        public short Annual { get; set; }
    }
}