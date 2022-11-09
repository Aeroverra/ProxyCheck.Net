using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyCheck.Models.API
{
    internal class QueryResponse
    {
        public ResponseStatus Status { get; set; }
        public string Node { get; set; }
        public Dictionary<string,IResponseData> ResponseData { get; set; } = new Dictionary<string, IResponseData>();
        public decimal? QueryTime { get; set; }
        public string Message { get; set; }
    }
}
