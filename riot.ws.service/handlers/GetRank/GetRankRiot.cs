using riot.ws.shared.api;
using riot.ws.infrastructure.dto;
using riot.ws.shared.api;


namespace riot.ws.service.handlers.GetRank
{

    public class GetRankRiot : AbstractEndpoint
    {
        private string path = "https://euw1.api.riotgames.com/lol/league/v4/entries/by-summoner/";
        public GetRankRiot(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<List<RankDto>> GetRankByIdSummoner(string summonerId)
        {
            path += $"{summonerId}";
            return await DoCallAsync<List<RankDto>>(path, HttpMethod.Get);
        }


    }
}
