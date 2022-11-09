using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyCheck.Models.API
{
    internal class AttackHistory
    {
        public long? Total { get; set; }
        public long? VulnerabilityProbing { get; set; }
        public long? ForumSpam { get; set; }
        public long? LoginAttempt { get; set; }
        public long? RegistrationAttempt { get; set; }
    }
}
