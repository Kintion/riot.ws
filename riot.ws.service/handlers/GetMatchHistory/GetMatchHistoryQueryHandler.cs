

using EFCore.BulkExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using riot.ws.domain.Context;
using riot.ws.domain.Models;
using riot.ws.infrastructure.dto;
using riot.ws.infrastructure.Maps;
using riot.ws.shared.infrastructure;
using System.Collections.Generic;

namespace riot.ws.service.handlers.GetMatchHistory
{
    public class GetMatchHistoryQueryHandler : IRequestHandler<GetMatchHistoryQuery, GetMatchHistoryResponse>
    {
        private readonly PostgresContext _context;
        private readonly GetMatchHistoryRiot _riot;
        private readonly IObjectMapper Mapper;



        public GetMatchHistoryQueryHandler(PostgresContext context, GetMatchHistoryRiot riot, IObjectMapper mapper)
        {
            _context = context;
            _riot = riot;
            Mapper = mapper;
        }
        public async Task<GetMatchHistoryResponse> Handle(GetMatchHistoryQuery request, CancellationToken cancellationToken)
        {
            List<Partida> partidas = await _context.Partida
                .Include(x => x.Participantes)
                .Where(y => y.Participantes.Any(c => c.Puuid == request.Puuid)).OrderByDescending(x => x.Fechafinalizacion).AsNoTracking().ToListAsync();

            List<MatchResponse> matches = new List<MatchResponse>();

            if (partidas.Count > 0)
            {
                matches.AddRange(Mapper.Map<List<Partida>, List<MatchResponse>>(partidas));

            }

            if (request.Update || partidas.Count == 0)
            {
                List<String> matchIds = await _riot.GetMatchHistoryListByPuuid(request.Puuid, partidas.FirstOrDefault()?.Fechafinalizacion??Constants.FechaNuevoSplit);

                List<MatchDto> newMatches = new List<MatchDto>();

                foreach (String matchId in matchIds)
                {
                    newMatches.Add(await _riot.GetMatchById(matchId));
                }

                if (newMatches.Count > 0)
                {
                    List<Partida> newPartidas = Mapper.Map<List<MatchDto>, List<Partida>>(newMatches);

                    List<SummonerAccount> summoners = Mapper.Map<List<Participant>, List<SummonerAccount>>(newMatches.SelectMany(x => x.Info.Participants).ToList());
                    summoners = summoners.DistinctBy(x => x.Puuid).ToList();

                    List<String> puuidsEnBaseDeDatos = await _context.SummonerAccounts.Select(x => x.Puuid).ToListAsync();

                    List<SummonerAccount> summonersNoCreados = summoners.Where(y => !puuidsEnBaseDeDatos.Contains(y.Puuid)).ToList();

                    await _context.SummonerAccounts.AddRangeAsync(summonersNoCreados);

                    await _context.Partida.AddRangeAsync(newPartidas);

                    await _context.SaveChangesAsync();

                    matches.AddRange(Mapper.Map<List<Partida>, List<MatchResponse>>(newPartidas));

                }



            }


            return new GetMatchHistoryResponse(matches);

        }
    }
}
