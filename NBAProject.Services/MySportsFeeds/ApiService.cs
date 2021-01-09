using System;
using System.Threading.Tasks;
using NBAProject.Models.MySportsFeeds.ApiResponses;
using NBAProject.Models.MySportsFeeds.JsonConverters;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace NBAProject.Services.MySportsFeeds
{
    public class ApiService<T> : IApiService<T> where T : ApiResponse
    {
        private readonly IApiSettings _apiSettings;

        public ApiService(IApiSettings apiSettings)
        {
            _apiSettings = apiSettings;
        }

        public T Get(RestRequest getRequest)
        {
            var client = GetRestClient();
            var response = client.Execute(getRequest);
            return JsonConvert.DeserializeObject<T>(response.Content, Converter.Settings);
        }

        public async Task<T> GetAsync(RestRequest getRequest)
        {
            var client = GetRestClient();
            var response = await client.ExecuteAsync(getRequest);
            return JsonConvert.DeserializeObject<T>(response.Content, Converter.Settings);
        }

        private RestClient GetRestClient()
        {
            return new()
            {
                BaseUrl = new Uri(_apiSettings.BaseUrl),
                Authenticator = new HttpBasicAuthenticator(_apiSettings.ApiUsername, _apiSettings.ApiPassword)
            };
        }
    }
}