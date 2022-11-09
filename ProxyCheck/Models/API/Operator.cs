using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyCheck.Models.API
{
    internal class Operator
    {
        public string Name { get; set; }
        public Uri Url { get; set; }
        public string Anonymity { get; set; }
        public string Popularity { get; set; }
        public List<string> Protocols { get; set; }
        public Policies Policies { get; set; }
    }
}
