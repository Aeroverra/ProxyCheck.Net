using ProxyCheck.Models.API;
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

        public async Task<QueryResponse> QueryAsync(params string[] inputs)
        {
            var url = "https://proxycheck.io/v2/";

            var queryParameters = new Dictionary<string, string>
            {
                { "key", ApiKey }
            };
            var queryStringContent = new FormUrlEncodedContent(queryParameters);
            var queryString = "?" + await queryStringContent.ReadAsStringAsync();

            var bodyParameters = new Dictionary<string, string>
            {
                { "ips", string.Join(",",inputs) }
            };


            var encodedContent = new FormUrlEncodedContent(bodyParameters);

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url + queryString, encodedContent);
                string json = await response.Content.ReadAsStringAsync();
                var queryResponse = QueryResponse.FromJson(json);
                return queryResponse;
            }
        }


    }
}
