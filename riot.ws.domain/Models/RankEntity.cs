


namespace riot.ws.domain.Models
{
    public class RankEntity
    {
        public string Leagueid { get; set; } = null!;

        public string Queuetype { get; set; } = null!;

        public string Tier { get; set; } = null!;

        public string Rank { get; set; } = null!;

        public string Summonerid { get; set; } = null!;

        public int Leaguepoints { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public bool Veteran { get; set; }

        public bool Inactive { get; set; }

        public bool Freshblood { get; set; }

        public bool Hotstreak { get; set; }
        public SummonerAccount SummonerAccount { get; set; }
    }
}
