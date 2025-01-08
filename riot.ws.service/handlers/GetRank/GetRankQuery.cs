

using MediatR;
using riot.ws.infrastructure.dto;

namespace riot.ws.service.handlers.GetRank
{
    public class GetRankQuery: IRequest<List<RankDto>>
    {
        public string SummonerId { get; set; }

    }
}
