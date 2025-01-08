

using Newtonsoft.Json;

namespace riot.ws.infrastructure.dto
{
    public class RankDto
    {
        [JsonProperty("leagueId")]
        public Guid LeagueId { get; set; }

        [JsonProperty("queueType")]
        public string QueueType { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("summonerId")]
        public string SummonerId { get; set; }

        [JsonProperty("leaguePoints")]
        public long LeaguePoints { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("veteran")]
        public bool Veteran { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("freshBlood")]
        public bool FreshBlood { get; set; }

        [JsonProperty("hotStreak")]
        public bool HotStreak { get; set; }
    }
}
