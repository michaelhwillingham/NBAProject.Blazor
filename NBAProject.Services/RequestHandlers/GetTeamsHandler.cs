using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NBAProject.Models.MySportsFeeds.ApiResponses;
using NBAProject.Models.Requests;
using NBAProject.Services.MySportsFeeds;
using RestSharp;

namespace NBAProject.Services.RequestHandlers
{
    public class GetTeamsHandler : IRequestHandler<GetTeams, GetTeamsResponse>
    {
        private readonly IApiService<GetTeamsResponse> _apiService;

        public GetTeamsHandler(IApiService<GetTeamsResponse> apiService)
        {
            _apiService = apiService;
        }

        public async Task<GetTeamsResponse> Handle(GetTeams request, CancellationToken token)
        {
            var restRequest = new RestRequest
            {
                Method = Method.GET,
                Resource = $"{request.Season}/standings.json",
                RequestFormat = DataFormat.Json
            };

            restRequest.AddHeader("Accept-Encoding", "gzip");

            var parameters = request.GetType().GetProperties().Where(p => p.GetValue(request) != null);

            foreach (var param in parameters)
                restRequest.AddParameter(param.Name.ToLower(), param.GetValue(request)?.ToString()!,
                    ParameterType.GetOrPost);

            return await _apiService.GetAsync(restRequest);
        }
    }
}