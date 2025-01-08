

using MediatR;

namespace riot.ws.service.handlers.GetSummoner
{
    public class GetSummonerQuery : IRequest<GetSummonerResponse>
    {
        public string Puuid { get; set; }
    }
}
