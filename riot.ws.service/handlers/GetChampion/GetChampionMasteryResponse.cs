

using Newtonsoft.Json;

namespace riot.ws.service.handlers.Champion
{
    public class GetChampionMasteryResponse
    {
        [JsonProperty("puuid")]
        public string Puuid { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("championLevel")]
        public long ChampionLevel { get; set; }

        [JsonProperty("championPoints")]
        public long ChampionPoints { get; set; }

        [JsonProperty("lastPlayTime")]
        public long LastPlayTime { get; set; }

        [JsonProperty("championPointsSinceLastLevel")]
        public long ChampionPointsSinceLastLevel { get; set; }

        [JsonProperty("championPointsUntilNextLevel")]
        public long ChampionPointsUntilNextLevel { get; set; }

        [JsonProperty("markRequiredForNextLevel")]
        public long MarkRequiredForNextLevel { get; set; }

        [JsonProperty("tokensEarned")]
        public long TokensEarned { get; set; }

        [JsonProperty("championSeasonMilestone")]
        public long ChampionSeasonMilestone { get; set; }

        [JsonProperty("nextSeasonMilestone")]
        public NextSeasonMilestone NextSeasonMilestone { get; set; }

        [JsonProperty("milestoneGrades", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MilestoneGrades { get; set; }
    }
    public partial class NextSeasonMilestone
    {
        [JsonProperty("requireGradeCounts")]
        public RequireGradeCounts RequireGradeCounts { get; set; }

        [JsonProperty("rewardMarks")]
        public long RewardMarks { get; set; }

        [JsonProperty("bonus")]
        public bool Bonus { get; set; }

        [JsonProperty("rewardConfig")]
        public RewardConfig RewardConfig { get; set; }

        [JsonProperty("totalGamesRequires")]
        public long TotalGamesRequires { get; set; }
    }

    public partial class RequireGradeCounts
    {
        [JsonProperty("B-")]
        public long B { get; set; }

        [JsonProperty("C-")]
        public long C { get; set; }
    }

    public partial class RewardConfig
    {
        [JsonProperty("rewardValue")]
        public string RewardValue { get; set; }

        [JsonProperty("rewardType")]
        public string RewardType { get; set; }

        [JsonProperty("maximumReward")]
        public long MaximumReward { get; set; }
    }

}
