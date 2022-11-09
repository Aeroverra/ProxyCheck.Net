using Newtonsoft.Json;
using ProxyCheck.JsonConverters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyCheck.Models.API
{
    internal class EmailData: IResponseData
    {
        [JsonConverter(typeof(YesNoBoolConverter))]
        public bool Disposable { get; set; }
    }
}
