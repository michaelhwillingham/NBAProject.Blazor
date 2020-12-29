using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using NBAProject.Models;
using Newtonsoft.Json;

namespace NBAProject.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Team>> GetAllTeamsAsync()
        {
            var request = GenerateHttpRequestMessage("fantasy/json/Teams");
            
            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            
            return JsonConvert.DeserializeObject<IEnumerable<Team>>(responseString);
        }

        public async Task<string> GetAllPlayersAsync()
        {
            var request = GenerateHttpRequestMessage("fantasy/json/Players");

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        private HttpRequestMessage GenerateHttpRequestMessage(string apiPath)
        {
            return new()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{ApiSettings.ApiBase}/{apiPath}"),
                Headers =
                {
                    {"Ocp-Apim-Subscription-Key", ApiSettings.ApiKey}
                }
            };
        }
    }
}