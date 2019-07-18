using System.Collections.Generic;
using System.Linq;

namespace SubscriptionServiceApi.Infrastructure.Models
{
    public class Identifier : Entity
    {
        public string Name { get; set; }
        public string Ip { get; set; }
        public string ComputerHash { get; set; }
        public IEnumerable<HistoryLog> HistoryLogs { get; set; }
    }
}