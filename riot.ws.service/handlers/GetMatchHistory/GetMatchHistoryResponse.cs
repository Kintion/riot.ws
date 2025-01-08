

using riot.ws.infrastructure.Maps;

namespace riot.ws.service.handlers.GetMatchHistory
{
    public class GetMatchHistoryResponse
    {
        public List<MatchResponse> matches;

        public GetMatchHistoryResponse(List<MatchResponse> matches)
        {
            this.matches = matches;
        }
    }
}
