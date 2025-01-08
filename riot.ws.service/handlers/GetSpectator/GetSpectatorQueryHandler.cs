
using MediatR;
using riot.ws.shared.api;

namespace riot.ws.service.handlers.GetSpectator
{
    public class GetSpectatorQueryHandler : AbstractEndpoint, IRequestHandler<GetSpectatorQuery, GetSpectatorResponse>
    {
        private readonly string path = "https://euw1.api.riotgames.com/lol/spectator/v5/active-games/by-summoner/iU4Q0gl90idBPmC_En8zvj6z-PS5UWeWQdVFFNSz53rgc0v-aXt6aSPf4RYayh-WhAYLq7LfU3Gx5Q";
        public GetSpectatorQueryHandler(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<GetSpectatorResponse> Handle(GetSpectatorQuery request, CancellationToken cancellationToken)
        {
            //path += request.Puuid;
            return await DoCallAsync<GetSpectatorResponse>(path, HttpMethod.Get);
        }
    }
}
