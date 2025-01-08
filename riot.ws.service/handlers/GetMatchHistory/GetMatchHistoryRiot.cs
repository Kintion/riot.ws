using riot.ws.infrastructure.dto;
using riot.ws.shared.api;


namespace riot.ws.service.handlers.GetMatchHistory
{
    public class GetMatchHistoryRiot : AbstractEndpoint
    {
        private string path = "https://europe.api.riotgames.com/lol/match/v5/matches/";
        public GetMatchHistoryRiot(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<List<String>> GetMatchHistoryListByPuuid(string puuid, DateTime fechaFinalizacion)
        {
            string customPath = path + $"by-puuid/{puuid}";

            DateTimeOffset dateTimeOffset = new DateTimeOffset(fechaFinalizacion).AddMinutes(1); ;

            long timestamp = dateTimeOffset.ToUnixTimeSeconds();


            Dictionary<string, string> queryParams = new Dictionary<string, string>();

            if (fechaFinalizacion != null)
            {
                queryParams = new Dictionary<string, string>
                {
                    { "startTime", $"{timestamp}"},
                    { "count", "100"},

                };
            }
            


            return await DoCallAsync<List<String>>(customPath, HttpMethod.Get, queryParams: queryParams);
        }

        public async Task<MatchDto> GetMatchById(string matchId)
        {
            string customPath = path + $"{matchId}";
            return await DoCallAsync<MatchDto>(customPath, HttpMethod.Get);

        }
    }
}
