using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ProxyCheck.JsonConverters;
using ProxyCheck.Models.API;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyCheck.Extensions
{
    internal static class QueryResponseExtensions
    {
        public static QueryResponse FromJson(this string json)
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
            return JsonConvert.DeserializeObject<QueryResponse>(json, Settings);
        }
    }
}
