

using MediatR;
using riot.ws.domain.Context;
using riot.ws.domain.Models;
using riot.ws.infrastructure.dto;
using riot.ws.shared.infrastructure;

namespace riot.ws.service.handlers.GetRank
{
    public class GetRankQueryHandler : IRequestHandler<GetRankQuery, List<RankDto>>
    {
        private readonly PostgresContext _context;
        private readonly GetRankRiot _riot;
        private readonly IObjectMapper Mapper;
        

        public GetRankQueryHandler(PostgresContext context, GetRankRiot riot, IObjectMapper mapper) 
        {
            _context = context;
            _riot = riot;
            Mapper = mapper;
        }

        
        public async Task<List<RankDto>> Handle(GetRankQuery request, CancellationToken cancellationToken)
        {
            List<RankDto> ranks = await _riot.GetRankByIdSummoner(request.SummonerId);


            await _context.Ranks.AddRangeAsync(Mapper.Map<List<RankDto>, List<RankEntity>>(ranks));

            await _context.SaveChangesAsync();  

            return ranks;
        }
    }
}
