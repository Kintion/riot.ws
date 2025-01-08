using MediatR;
using Microsoft.EntityFrameworkCore;
using riot.ws.domain.Context;
using riot.ws.domain.Models;
using riot.ws.infrastructure.dto;
using riot.ws.service.handlers.GetSummoner;
using riot.ws.shared.infrastructure;


namespace riot.ws.service.handlers.Account.GetAccount
{
    public class GetAccountQueryHandler : IRequestHandler<GetAccountQuery, GetAccountQueryResponse>
    {
        private readonly PostgresContext _context;
        private readonly GetAccountRiot _riot;
        private readonly IMediator _sender;
        private readonly IObjectMapper Mapper;

        public GetAccountQueryHandler(PostgresContext context, GetAccountRiot riot, IMediator sender, IObjectMapper mapper)
        {
            _context = context;
            _riot = riot;
            _sender = sender;
            Mapper = mapper;
        }
        public async Task<GetAccountQueryResponse> Handle(GetAccountQuery request, CancellationToken cancellationToken)
        {
            SummonerAccount? summoner = await _context.SummonerAccounts.Include(x => x.Ranks)
                .Include(x => x.Participantes.Take(20)).ThenInclude(x => x.Match)
                .Where(x => x.Gamename.ToLower() == request.GameName.ToLower() 
                && x.Tagline.ToLower() == request.TagLine.ToLower()).AsNoTracking().FirstOrDefaultAsync();

            if (summoner == null || request.Update.GetValueOrDefault(false))
            {
                AccountDto account = await _riot.GetAccountByGameName(request.GameName, request.TagLine);

                GetSummonerResponse response = await _sender.Send(new GetSummonerQuery { Puuid = account.Puuid });

                summoner = new SummonerAccount
                {
                    Puuid = account.Puuid,
                    Gamename = account.GameName,
                    Tagline = account.TagLine,
                    Id = response.Id,
                    Profileiconid = response.ProfileIconId,
                    Summonerid = response.AccountId,
                    Revisiondate = DateTimeOffset.FromUnixTimeMilliseconds(response.RevisionDate).DateTime,
                    Summonerlevel = response.SummonerLevel
                };

                if (summoner != null)
                {
                    _context.Update(summoner);
                }
                else
                {
                    _context.SummonerAccounts.Add(summoner);

                }
                await _context.SaveChangesAsync();
            } 

            return new GetAccountQueryResponse
            {
                Puuid = summoner.Puuid,
                Gamename = summoner.Gamename,
                Tagline = summoner.Tagline,
                Id = summoner.Id,
                Profileiconid = summoner.Profileiconid,
                Revisiondate = summoner.Revisiondate,
                Summonerid=summoner.Summonerid,
                Summonerlevel=summoner.Summonerlevel,
                Participantes = Mapper.Map<List<Participante>,List<ParticipanteDto>>(summoner.Participantes.ToList()),
                Ranks= Mapper.Map<List<RankEntity>, List<RankDto>>(summoner.Ranks.ToList()),
            };
        }
    }
}
