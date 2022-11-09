using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyCheck.Models.API
{
    public class Policies
    {
        public bool? AdFiltering { get; set; }
        public bool? FreeAccess { get; set; }
        public bool? PaidAccess { get; set; }
        public bool? PortForwarding { get; set; }
        public bool? Logging { get; set; }
        public bool? AnonymousPayments { get; set; }
        public bool? CryptoPayments { get; set; }
        public bool? TraceableOwnership { get; set; }
    }
}
