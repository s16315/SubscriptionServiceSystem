using System;
using Org.BouncyCastle.Asn1.X509;

namespace SubscriptionServiceApi.Infrastructure.Models
{
    public class HistoryLog
    {
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
    }
}