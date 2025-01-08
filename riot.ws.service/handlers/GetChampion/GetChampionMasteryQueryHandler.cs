using MediatR;
using riot.ws.shared.api;

namespace riot.ws.service.handlers.Champion
{
    public class GetChampionMasteryQueryHandler : AbstractEndpoint, IRequestHandler<GetChampionMasteryQuery, List<GetChampionMasteryResponse>>
    {
        private readonly string path = "https://euw1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-puuid/iU4Q0gl90idBPmC_En8zvj6z-PS5UWeWQdVFFNSz53rgc0v-aXt6aSPf4RYayh-WhAYLq7LfU3Gx5Q";

        public GetChampionMasteryQueryHandler(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<List<GetChampionMasteryResponse>> Handle(GetChampionMasteryQuery request, CancellationToken cancellationToken)
        {
            return await DoCallAsync<List<GetChampionMasteryResponse>>(path, HttpMethod.Get);
        }
    }
}
