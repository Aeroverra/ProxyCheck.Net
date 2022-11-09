using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using ProxyCheck.JsonConverters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ProxyCheck.Models.API
{
    public class QueryResponse
    {
        public ResponseStatus Status { get; set; }
        public string Node { get; set; }
        public decimal? QueryTime { get; set; }
        public string Message { get; set; }

        public List<IPData> IPs { get; set; } = new List<IPData>();
        public List<EmailData> Emails { get; set; } = new List<EmailData>();
        [JsonExtensionData]
        internal Dictionary<string, JToken> Remaining { get; set; } = new Dictionary<string, JToken>();

        private void DeserializeData(JsonSerializerSettings Settings)
        {
            foreach (var key in Remaining.Keys)
            {
                var jsonData = Remaining[key].ToString();
                if (key.Length > 15 || key.Contains("@"))
                {
                    var emailData = JsonConvert.DeserializeObject<EmailData>(jsonData, Settings);
                    emailData.Email = key;
                    Emails.Add(emailData);
                }
                else
                {
                    var ipData = JsonConvert.DeserializeObject<IPData>(jsonData, Settings);
                    ipData.IP = key;
                    IPs.Add(ipData);
                }
            }
        }


        internal static QueryResponse FromJson(string json)
        {
            JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
                {
                     YesNoBoolConverter.Singleton,
                     new UnixDateTimeConverter()
                },
            };
            var queryResponse = JsonConvert.DeserializeObject<QueryResponse>(json, Settings);
            queryResponse.DeserializeData(Settings);
            return queryResponse;
        }

    }
}
