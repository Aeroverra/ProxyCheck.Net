using Newtonsoft.Json;
using ProxyCheck.JsonConverters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyCheck.Models.API
{
    public class EmailData: IResponseData
    {
        /// <summary>
        /// Contains the Email
        /// Specific to this library to avoid dictionary use
        /// </summary>
        [JsonIgnore]
        public string Email { get; set; }

        [JsonConverter(typeof(YesNoBoolConverter))]
        public bool Disposable { get; set; }
    }
}
