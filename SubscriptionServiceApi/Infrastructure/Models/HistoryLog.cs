using System;
using Org.BouncyCastle.Asn1.X509;

namespace SubscriptionServiceApi.Infrastructure.Models
{
    public class HistoryLog : Entity
    {
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
    }
}