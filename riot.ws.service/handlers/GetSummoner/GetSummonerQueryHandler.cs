

using MediatR;
using riot.ws.shared.api;

namespace riot.ws.service.handlers.GetSummoner
{
    public class GetSummonerQueryHandler : AbstractEndpoint, IRequestHandler<GetSummonerQuery, GetSummonerResponse>
    {
        private string path = "https://euw1.api.riotgames.com/lol/summoner/v4/summoners/by-puuid/";

        public GetSummonerQueryHandler(HttpClient httpClient) : base(httpClient)
        {
        }

        async Task<GetSummonerResponse> IRequestHandler<GetSummonerQuery, GetSummonerResponse>.Handle(GetSummonerQuery request, CancellationToken cancellationToken)
        {
            path += request.Puuid;
            return await DoCallAsync<GetSummonerResponse>(path, HttpMethod.Get);
        }
    }
}
