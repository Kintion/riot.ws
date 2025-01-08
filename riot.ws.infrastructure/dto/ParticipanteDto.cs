

using riot.ws.infrastructure.Maps;

namespace riot.ws.infrastructure.dto
{
    public class ParticipanteDto
    {
        public string Matchid { get; set; } = null!;

        public int Teamid { get; set; }

        public string Puuid { get; set; } = null!;

        public int Championid { get; set; }

        public int Item0 { get; set; }

        public int Item1 { get; set; }

        public int Item2 { get; set; }

        public int Item3 { get; set; }

        public int Item4 { get; set; }

        public int Item5 { get; set; }

        public int Item6 { get; set; }
        public int Summoner1Id { get; set; }
        public int Summoner2Id { get; set; }
        public bool Win { get; set; }
        public int TotalDamageDealt { get; set; }
        public string TeamPosition { get; set; }
        public MatchResponse Match { get; set; }

    }
}
