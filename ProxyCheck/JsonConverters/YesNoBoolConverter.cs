using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyCheck.JsonConverters
{
    public class YesNoBoolConverter : JsonConverter
    {
        public override bool CanWrite { get { return false; } }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = (string)reader.Value;
            if ("yes".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if ("no".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(String) || objectType == typeof(Boolean))
            {
                return true;
            }
            return false;
        }

        public static readonly YesNoBoolConverter Singleton = new YesNoBoolConverter();
    }
}
