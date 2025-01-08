using riot.ws.domain.Models;
using riot.ws.infrastructure.dto;

namespace riot.ws.service.handlers.Account.GetAccount
{

    public class GetAccountQueryResponse
    {
        public string Puuid { get; set; }

        public string Gamename { get; set; } 

        public string Tagline { get; set; } 

        public string Id { get; set; } 

        public string Summonerid { get; set; }

        public int Profileiconid { get; set; }

        public DateTime Revisiondate { get; set; }

        public int Summonerlevel { get; set; }

        public List<ParticipanteDto> Participantes { get; set; } 

        public List<RankDto> Ranks { get; set; }
    }
}
