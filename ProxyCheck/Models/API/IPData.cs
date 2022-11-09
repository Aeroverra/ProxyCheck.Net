using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyCheck.Models.API
{
    internal class IPData : IResponseData
    {
        public string Asn { get; set; }
        public string Provider { get; set; }
        public string Continent { get; set; }
        public string Country { get; set; }
        public string Timezone { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string Isocode { get; set; }
        public bool Proxy { get; set; }
        public string Type { get; set; }
        public long? Risk { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Region { get; set; }
        public int? Regioncode { get; set; }
        public Operator Operator { get; set; }
        public int? Port { get; set; }
        public AttackHistory AttackHistory { get; set; }
        public string LastSeenHuman { get; set; }
        public DateTimeOffset? LastSeenUnix { get; set; }
        public string Error { get; set; }
    }
}
