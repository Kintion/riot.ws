

using Newtonsoft.Json;

namespace riot.ws.service.handlers.GetSpectator
{
    public class GetSpectatorResponse
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }

        [JsonProperty("mapId")]
        public long MapId { get; set; }

        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("gameQueueConfigId")]
        public long GameQueueConfigId { get; set; }

        [JsonProperty("participants")]
        public List<Participant> Participants { get; set; }

        [JsonProperty("observers")]
        public Observers Observers { get; set; }

        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("bannedChampions")]
        public List<object> BannedChampions { get; set; }

        [JsonProperty("gameStartTime")]
        public long GameStartTime { get; set; }

        [JsonProperty("gameLength")]
        public long GameLength { get; set; }
    }

    public partial class Observers
    {
        [JsonProperty("encryptionKey")]
        public string EncryptionKey { get; set; }
    }

    public partial class Participant
    {
        [JsonProperty("puuid")]
        public string Puuid { get; set; }

        [JsonProperty("teamId")]
        public long TeamId { get; set; }

        [JsonProperty("spell1Id")]
        public long Spell1Id { get; set; }

        [JsonProperty("spell2Id")]
        public long Spell2Id { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("profileIconId")]
        public long ProfileIconId { get; set; }

        [JsonProperty("riotId")]
        public string RiotId { get; set; }

        [JsonProperty("bot")]
        public bool Bot { get; set; }

        [JsonProperty("summonerId")]
        public string SummonerId { get; set; }

        [JsonProperty("gameCustomizationObjects")]
        public List<object> GameCustomizationObjects { get; set; }

        [JsonProperty("perks")]
        public Perks Perks { get; set; }
    }

    public partial class Perks
    {
        [JsonProperty("perkIds")]
        public List<long> PerkIds { get; set; }

        [JsonProperty("perkStyle")]
        public long PerkStyle { get; set; }

        [JsonProperty("perkSubStyle")]
        public long PerkSubStyle { get; set; }
    
    }
}
