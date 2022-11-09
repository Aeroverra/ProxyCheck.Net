using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProxyCheck
{
    public class ProxyChecker
    {
        private readonly string ApiKey;
        public ProxyChecker(string apiKey)
        {
            if (apiKey == null)
            {
                apiKey = string.Empty;
            }

            ApiKey = apiKey;
        }

        public async Task QueryAsync(params string[] inputs)
        {
            var url = "https://proxycheck.io/v2/";

            var parameters = new Dictionary<string, string>
            {
                { "ips", string.Join(",",inputs) }
            };

            var encodedContent = new FormUrlEncodedContent(parameters);

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, encodedContent);

            }
        }


    }
}
