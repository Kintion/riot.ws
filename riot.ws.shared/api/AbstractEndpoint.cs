
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace riot.ws.shared.api
{


        public abstract class AbstractEndpoint
        {
            private readonly HttpClient _httpClient;

            private readonly string? _apiKey;
            protected AbstractEndpoint(HttpClient httpClient)
            {
                _httpClient = httpClient;
                _apiKey = Environment.GetEnvironmentVariable("RiotApiKey");
        }

            protected async Task<T> HandleConnectionExceptionAsync<T>(Func<Task<T>> action)
            {
                try
                {
                    return await action();
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception("Connection exception occurred.", ex);
                }
            }


            protected string AddQueryParams(string baseUrl, Dictionary<string, string> queryParams)
            {
                var uriBuilder = new UriBuilder(baseUrl+ "/ids");
                var query = System.Web.HttpUtility.ParseQueryString(uriBuilder.Query);

                foreach (var param in queryParams)
                {
                    query[param.Key] = param.Value;
                }

                uriBuilder.Query = query.ToString();
                return uriBuilder.ToString();
            }
            protected Uri CreateUri(string uriPath, Dictionary<string, string> queryParams = null)
            {
                try
                {
                    if (queryParams != null)
                    {
                        uriPath = AddQueryParams(uriPath, queryParams);
                    }

                    return new Uri(uriPath);
                }
                catch (UriFormatException ex)
                {
                    throw new Exception("Invalid URI format.", ex);
                }
            }

        protected HttpRequestMessage CreateRequestMessage(HttpMethod method, string url, object body)
            {
                var request = new HttpRequestMessage(method, CreateUri(url));

                if (body != null)
                {
                    string jsonBody = JsonConvert.SerializeObject(body);
                    request.Content = new StringContent(jsonBody);
                    request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                }

                request.Headers.Add("X-Riot-Token", _apiKey);
                return request;
            }

            protected async Task<T> DoCallAsync<T>(string path, HttpMethod httpMethod, object body = null, Dictionary<string, string> queryParams = null)
            {
                return await HandleConnectionExceptionAsync(async () =>
                {
                    var fullUrl = CreateUri(path, queryParams).ToString();

                    var request = CreateRequestMessage(httpMethod, fullUrl, body);

                    using var response = await _httpClient.SendAsync(request);

                    response.EnsureSuccessStatusCode(); // Throws if the status code is not 2xx

                    var responseContent = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<T>(responseContent);
                });
            }
        }
}


