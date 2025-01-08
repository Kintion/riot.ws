
using Newtonsoft.Json;


namespace riot.ws.infrastructure.dto
    {


        public partial class MatchDto
        {
            [JsonProperty("metadata")]
            public Metadata Metadata { get; set; }

            [JsonProperty("info")]
            public Info Info { get; set; }
        }

        public partial class Info
        {
            [JsonProperty("endOfGameResult")]
            public string EndOfGameResult { get; set; }

            [JsonProperty("gameCreation")]
            public long GameCreation { get; set; }

            [JsonProperty("gameDuration")]
            public long GameDuration { get; set; }

            [JsonProperty("gameEndTimestamp")]
            public long GameEndTimestamp { get; set; }

            [JsonProperty("gameId")]
            public long GameId { get; set; }

            [JsonProperty("gameMode")]
            public string GameMode { get; set; }

            [JsonProperty("gameName")]
            public string GameName { get; set; }

            [JsonProperty("gameStartTimestamp")]
            public long GameStartTimestamp { get; set; }

            [JsonProperty("gameType")]
            public string GameType { get; set; }

            [JsonProperty("gameVersion")]
            public string GameVersion { get; set; }

            [JsonProperty("mapId")]
            public long MapId { get; set; }

            [JsonProperty("participants")]
            public List<Participant> Participants { get; set; }

            [JsonProperty("platformId")]
            public string PlatformId { get; set; }

            [JsonProperty("queueId")]
            public long QueueId { get; set; }

            [JsonProperty("teams")]
            public List<Team> Teams { get; set; }

            [JsonProperty("tournamentCode")]
            public string TournamentCode { get; set; }
        }

        public partial class Participant
        {
            [JsonProperty("allInPings")]
            public long AllInPings { get; set; }

            [JsonProperty("assistMePings")]
            public long AssistMePings { get; set; }

            [JsonProperty("assists")]
            public long Assists { get; set; }

            [JsonProperty("baronKills")]
            public long BaronKills { get; set; }

            [JsonProperty("basicPings")]
            public long BasicPings { get; set; }

            [JsonProperty("bountyLevel")]
            public long BountyLevel { get; set; }

            [JsonProperty("challenges")]
            public Challenges Challenges { get; set; }

            [JsonProperty("champExperience")]
            public long ChampExperience { get; set; }

            [JsonProperty("champLevel")]
            public long ChampLevel { get; set; }

            [JsonProperty("championId")]
            public long ChampionId { get; set; }

            [JsonProperty("championName")]
            public string ChampionName { get; set; }

            [JsonProperty("championTransform")]
            public long ChampionTransform { get; set; }

            [JsonProperty("commandPings")]
            public long CommandPings { get; set; }

            [JsonProperty("consumablesPurchased")]
            public long ConsumablesPurchased { get; set; }

            [JsonProperty("damageDealtToBuildings")]
            public long DamageDealtToBuildings { get; set; }

            [JsonProperty("damageDealtToObjectives")]
            public long DamageDealtToObjectives { get; set; }

            [JsonProperty("damageDealtToTurrets")]
            public long DamageDealtToTurrets { get; set; }

            [JsonProperty("damageSelfMitigated")]
            public long DamageSelfMitigated { get; set; }

            [JsonProperty("dangerPings")]
            public long DangerPings { get; set; }

            [JsonProperty("deaths")]
            public long Deaths { get; set; }

            [JsonProperty("detectorWardsPlaced")]
            public long DetectorWardsPlaced { get; set; }

            [JsonProperty("doubleKills")]
            public long DoubleKills { get; set; }

            [JsonProperty("dragonKills")]
            public long DragonKills { get; set; }

            [JsonProperty("eligibleForProgression")]
            public bool EligibleForProgression { get; set; }

            [JsonProperty("enemyMissingPings")]
            public long EnemyMissingPings { get; set; }

            [JsonProperty("enemyVisionPings")]
            public long EnemyVisionPings { get; set; }

            [JsonProperty("firstBloodAssist")]
            public bool FirstBloodAssist { get; set; }

            [JsonProperty("firstBloodKill")]
            public bool FirstBloodKill { get; set; }

            [JsonProperty("firstTowerAssist")]
            public bool FirstTowerAssist { get; set; }

            [JsonProperty("firstTowerKill")]
            public bool FirstTowerKill { get; set; }

            [JsonProperty("gameEndedInEarlySurrender")]
            public bool GameEndedInEarlySurrender { get; set; }

            [JsonProperty("gameEndedInSurrender")]
            public bool GameEndedInSurrender { get; set; }

            [JsonProperty("getBackPings")]
            public long GetBackPings { get; set; }

            [JsonProperty("goldEarned")]
            public long GoldEarned { get; set; }

            [JsonProperty("goldSpent")]
            public long GoldSpent { get; set; }

            [JsonProperty("holdPings")]
            public long HoldPings { get; set; }

            [JsonProperty("individualPosition")]
            public string IndividualPosition { get; set; }

            [JsonProperty("inhibitorKills")]
            public long InhibitorKills { get; set; }

            [JsonProperty("inhibitorTakedowns")]
            public long InhibitorTakedowns { get; set; }

            [JsonProperty("inhibitorsLost")]
            public long InhibitorsLost { get; set; }

            [JsonProperty("item0")]
            public long Item0 { get; set; }

            [JsonProperty("item1")]
            public long Item1 { get; set; }

            [JsonProperty("item2")]
            public long Item2 { get; set; }

            [JsonProperty("item3")]
            public long Item3 { get; set; }

            [JsonProperty("item4")]
            public long Item4 { get; set; }

            [JsonProperty("item5")]
            public long Item5 { get; set; }

            [JsonProperty("item6")]
            public long Item6 { get; set; }

            [JsonProperty("itemsPurchased")]
            public long ItemsPurchased { get; set; }

            [JsonProperty("killingSprees")]
            public long KillingSprees { get; set; }

            [JsonProperty("kills")]
            public long Kills { get; set; }

            [JsonProperty("lane")]
            public string Lane { get; set; }

            [JsonProperty("largestCriticalStrike")]
            public long LargestCriticalStrike { get; set; }

            [JsonProperty("largestKillingSpree")]
            public long LargestKillingSpree { get; set; }

            [JsonProperty("largestMultiKill")]
            public long LargestMultiKill { get; set; }

            [JsonProperty("longestTimeSpentLiving")]
            public long LongestTimeSpentLiving { get; set; }

            [JsonProperty("magicDamageDealt")]
            public long MagicDamageDealt { get; set; }

            [JsonProperty("magicDamageDealtToChampions")]
            public long MagicDamageDealtToChampions { get; set; }

            [JsonProperty("magicDamageTaken")]
            public long MagicDamageTaken { get; set; }

            [JsonProperty("missions")]
            public Dictionary<string, long> Missions { get; set; }

            [JsonProperty("needVisionPings")]
            public long NeedVisionPings { get; set; }

            [JsonProperty("neutralMinionsKilled")]
            public long NeutralMinionsKilled { get; set; }

            [JsonProperty("nexusKills")]
            public long NexusKills { get; set; }

            [JsonProperty("nexusLost")]
            public long NexusLost { get; set; }

            [JsonProperty("nexusTakedowns")]
            public long NexusTakedowns { get; set; }

            [JsonProperty("objectivesStolen")]
            public long ObjectivesStolen { get; set; }

            [JsonProperty("objectivesStolenAssists")]
            public long ObjectivesStolenAssists { get; set; }

            [JsonProperty("onMyWayPings")]
            public long OnMyWayPings { get; set; }

            [JsonProperty("participantId")]
            public long ParticipantId { get; set; }

            [JsonProperty("pentaKills")]
            public long PentaKills { get; set; }

            [JsonProperty("perks")]
            public Perks Perks { get; set; }

            [JsonProperty("physicalDamageDealt")]
            public long PhysicalDamageDealt { get; set; }

            [JsonProperty("physicalDamageDealtToChampions")]
            public long PhysicalDamageDealtToChampions { get; set; }

            [JsonProperty("physicalDamageTaken")]
            public long PhysicalDamageTaken { get; set; }

            [JsonProperty("placement")]
            public long Placement { get; set; }

            [JsonProperty("playerAugment1")]
            public long PlayerAugment1 { get; set; }

            [JsonProperty("playerAugment2")]
            public long PlayerAugment2 { get; set; }

            [JsonProperty("playerAugment3")]
            public long PlayerAugment3 { get; set; }

            [JsonProperty("playerAugment4")]
            public long PlayerAugment4 { get; set; }

            [JsonProperty("playerAugment5")]
            public long PlayerAugment5 { get; set; }

            [JsonProperty("playerAugment6")]
            public long PlayerAugment6 { get; set; }

            [JsonProperty("playerSubteamId")]
            public long PlayerSubteamId { get; set; }

            [JsonProperty("profileIcon")]
            public long ProfileIcon { get; set; }

            [JsonProperty("pushPings")]
            public long PushPings { get; set; }

            [JsonProperty("puuid")]
            public string Puuid { get; set; }

            [JsonProperty("quadraKills")]
            public long QuadraKills { get; set; }

            [JsonProperty("retreatPings")]
            public long RetreatPings { get; set; }

            [JsonProperty("riotIdGameName")]
            public string RiotIdGameName { get; set; }

            [JsonProperty("riotIdTagline")]
            public string RiotIdTagline { get; set; }

            [JsonProperty("role")]
            public string Role { get; set; }

            [JsonProperty("sightWardsBoughtInGame")]
            public long SightWardsBoughtInGame { get; set; }

            [JsonProperty("spell1Casts")]
            public long Spell1Casts { get; set; }

            [JsonProperty("spell2Casts")]
            public long Spell2Casts { get; set; }

            [JsonProperty("spell3Casts")]
            public long Spell3Casts { get; set; }

            [JsonProperty("spell4Casts")]
            public long Spell4Casts { get; set; }

            [JsonProperty("subteamPlacement")]
            public long SubteamPlacement { get; set; }

            [JsonProperty("summoner1Casts")]
            public long Summoner1Casts { get; set; }

            [JsonProperty("summoner1Id")]
            public long Summoner1Id { get; set; }

            [JsonProperty("summoner2Casts")]
            public long Summoner2Casts { get; set; }

            [JsonProperty("summoner2Id")]
            public long Summoner2Id { get; set; }

            [JsonProperty("summonerId")]
            public string SummonerId { get; set; }

            [JsonProperty("summonerLevel")]
            public long SummonerLevel { get; set; }

            [JsonProperty("summonerName")]
            public string SummonerName { get; set; }

            [JsonProperty("teamEarlySurrendered")]
            public bool TeamEarlySurrendered { get; set; }

            [JsonProperty("teamId")]
            public long TeamId { get; set; }

            [JsonProperty("teamPosition")]
            public string TeamPosition { get; set; }

            [JsonProperty("timeCCingOthers")]
            public long TimeCCingOthers { get; set; }

            [JsonProperty("timePlayed")]
            public long TimePlayed { get; set; }

            [JsonProperty("totalAllyJungleMinionsKilled")]
            public long TotalAllyJungleMinionsKilled { get; set; }

            [JsonProperty("totalDamageDealt")]
            public long TotalDamageDealt { get; set; }

            [JsonProperty("totalDamageDealtToChampions")]
            public long TotalDamageDealtToChampions { get; set; }

            [JsonProperty("totalDamageShieldedOnTeammates")]
            public long TotalDamageShieldedOnTeammates { get; set; }

            [JsonProperty("totalDamageTaken")]
            public long TotalDamageTaken { get; set; }

            [JsonProperty("totalEnemyJungleMinionsKilled")]
            public long TotalEnemyJungleMinionsKilled { get; set; }

            [JsonProperty("totalHeal")]
            public long TotalHeal { get; set; }

            [JsonProperty("totalHealsOnTeammates")]
            public long TotalHealsOnTeammates { get; set; }

            [JsonProperty("totalMinionsKilled")]
            public long TotalMinionsKilled { get; set; }

            [JsonProperty("totalTimeCCDealt")]
            public long TotalTimeCcDealt { get; set; }

            [JsonProperty("totalTimeSpentDead")]
            public long TotalTimeSpentDead { get; set; }

            [JsonProperty("totalUnitsHealed")]
            public long TotalUnitsHealed { get; set; }

            [JsonProperty("tripleKills")]
            public long TripleKills { get; set; }

            [JsonProperty("trueDamageDealt")]
            public long TrueDamageDealt { get; set; }

            [JsonProperty("trueDamageDealtToChampions")]
            public long TrueDamageDealtToChampions { get; set; }

            [JsonProperty("trueDamageTaken")]
            public long TrueDamageTaken { get; set; }

            [JsonProperty("turretKills")]
            public long TurretKills { get; set; }

            [JsonProperty("turretTakedowns")]
            public long TurretTakedowns { get; set; }

            [JsonProperty("turretsLost")]
            public long TurretsLost { get; set; }

            [JsonProperty("unrealKills")]
            public long UnrealKills { get; set; }

            [JsonProperty("visionClearedPings")]
            public long VisionClearedPings { get; set; }

            [JsonProperty("visionScore")]
            public long VisionScore { get; set; }

            [JsonProperty("visionWardsBoughtInGame")]
            public long VisionWardsBoughtInGame { get; set; }

            [JsonProperty("wardsKilled")]
            public long WardsKilled { get; set; }

            [JsonProperty("wardsPlaced")]
            public long WardsPlaced { get; set; }

            [JsonProperty("win")]
            public bool Win { get; set; }
        }

        public partial class Challenges
        {
            [JsonProperty("12AssistStreakCount")]
            public long The12AssistStreakCount { get; set; }

            [JsonProperty("HealFromMapSources")]
            public double HealFromMapSources { get; set; }

            [JsonProperty("InfernalScalePickup")]
            public long InfernalScalePickup { get; set; }

            [JsonProperty("SWARM_DefeatAatrox")]
            public long SwarmDefeatAatrox { get; set; }

            [JsonProperty("SWARM_DefeatBriar")]
            public long SwarmDefeatBriar { get; set; }

            [JsonProperty("SWARM_DefeatMiniBosses")]
            public long SwarmDefeatMiniBosses { get; set; }

            [JsonProperty("SWARM_EvolveWeapon")]
            public long SwarmEvolveWeapon { get; set; }

            [JsonProperty("SWARM_Have3Passives")]
            public long SwarmHave3Passives { get; set; }

            [JsonProperty("SWARM_KillEnemy")]
            public long SwarmKillEnemy { get; set; }

            [JsonProperty("SWARM_PickupGold")]
            public long SwarmPickupGold { get; set; }

            [JsonProperty("SWARM_ReachLevel50")]
            public long SwarmReachLevel50 { get; set; }

            [JsonProperty("SWARM_Survive15Min")]
            public long SwarmSurvive15Min { get; set; }

            [JsonProperty("SWARM_WinWith5EvolvedWeapons")]
            public long SwarmWinWith5EvolvedWeapons { get; set; }

            [JsonProperty("abilityUses")]
            public long AbilityUses { get; set; }

            [JsonProperty("acesBefore15Minutes")]
            public long AcesBefore15Minutes { get; set; }

            [JsonProperty("alliedJungleMonsterKills")]
            public long AlliedJungleMonsterKills { get; set; }

            [JsonProperty("baronTakedowns")]
            public long BaronTakedowns { get; set; }

            [JsonProperty("blastConeOppositeOpponentCount")]
            public long BlastConeOppositeOpponentCount { get; set; }

            [JsonProperty("bountyGold")]
            public long BountyGold { get; set; }

            [JsonProperty("buffsStolen")]
            public long BuffsStolen { get; set; }

            [JsonProperty("completeSupportQuestInTime")]
            public long CompleteSupportQuestInTime { get; set; }

            [JsonProperty("controlWardsPlaced")]
            public long ControlWardsPlaced { get; set; }

            [JsonProperty("damagePerMinute")]
            public double DamagePerMinute { get; set; }

            [JsonProperty("damageTakenOnTeamPercentage")]
            public double DamageTakenOnTeamPercentage { get; set; }

            [JsonProperty("dancedWithRiftHerald")]
            public long DancedWithRiftHerald { get; set; }

            [JsonProperty("deathsByEnemyChamps")]
            public long DeathsByEnemyChamps { get; set; }

            [JsonProperty("dodgeSkillShotsSmallWindow")]
            public long DodgeSkillShotsSmallWindow { get; set; }

            [JsonProperty("doubleAces")]
            public long DoubleAces { get; set; }

            [JsonProperty("dragonTakedowns")]
            public long DragonTakedowns { get; set; }

            [JsonProperty("earlyLaningPhaseGoldExpAdvantage")]
            public long EarlyLaningPhaseGoldExpAdvantage { get; set; }

            [JsonProperty("effectiveHealAndShielding")]
            public double EffectiveHealAndShielding { get; set; }

            [JsonProperty("elderDragonKillsWithOpposingSoul")]
            public long ElderDragonKillsWithOpposingSoul { get; set; }

            [JsonProperty("elderDragonMultikills")]
            public long ElderDragonMultikills { get; set; }

            [JsonProperty("enemyChampionImmobilizations")]
            public long EnemyChampionImmobilizations { get; set; }

            [JsonProperty("enemyJungleMonsterKills")]
            public long EnemyJungleMonsterKills { get; set; }

            [JsonProperty("epicMonsterKillsNearEnemyJungler")]
            public long EpicMonsterKillsNearEnemyJungler { get; set; }

            [JsonProperty("epicMonsterKillsWithin30SecondsOfSpawn")]
            public long EpicMonsterKillsWithin30SecondsOfSpawn { get; set; }

            [JsonProperty("epicMonsterSteals")]
            public long EpicMonsterSteals { get; set; }

            [JsonProperty("epicMonsterStolenWithoutSmite")]
            public long EpicMonsterStolenWithoutSmite { get; set; }

            [JsonProperty("firstTurretKilled")]
            public long FirstTurretKilled { get; set; }

            [JsonProperty("fistBumpParticipation")]
            public long FistBumpParticipation { get; set; }

            [JsonProperty("flawlessAces")]
            public long FlawlessAces { get; set; }

            [JsonProperty("fullTeamTakedown")]
            public long FullTeamTakedown { get; set; }

            [JsonProperty("gameLength")]
            public double GameLength { get; set; }

            [JsonProperty("getTakedownsInAllLanesEarlyJungleAsLaner", NullValueHandling = NullValueHandling.Ignore)]
            public long? GetTakedownsInAllLanesEarlyJungleAsLaner { get; set; }

            [JsonProperty("goldPerMinute")]
            public double GoldPerMinute { get; set; }

            [JsonProperty("hadOpenNexus")]
            public long HadOpenNexus { get; set; }

            [JsonProperty("immobilizeAndKillWithAlly")]
            public long ImmobilizeAndKillWithAlly { get; set; }

            [JsonProperty("initialBuffCount")]
            public long InitialBuffCount { get; set; }

            [JsonProperty("initialCrabCount")]
            public long InitialCrabCount { get; set; }

            [JsonProperty("jungleCsBefore10Minutes")]
            public double JungleCsBefore10Minutes { get; set; }

            [JsonProperty("junglerTakedownsNearDamagedEpicMonster")]
            public long JunglerTakedownsNearDamagedEpicMonster { get; set; }

            [JsonProperty("kTurretsDestroyedBeforePlatesFall")]
            public long KTurretsDestroyedBeforePlatesFall { get; set; }

            [JsonProperty("kda")]
            public double Kda { get; set; }

            [JsonProperty("killAfterHiddenWithAlly")]
            public long KillAfterHiddenWithAlly { get; set; }

            [JsonProperty("killParticipation")]
            public double KillParticipation { get; set; }

            [JsonProperty("killedChampTookFullTeamDamageSurvived")]
            public long KilledChampTookFullTeamDamageSurvived { get; set; }

            [JsonProperty("killingSprees")]
            public long KillingSprees { get; set; }

            [JsonProperty("killsNearEnemyTurret")]
            public long KillsNearEnemyTurret { get; set; }

            [JsonProperty("killsOnOtherLanesEarlyJungleAsLaner", NullValueHandling = NullValueHandling.Ignore)]
            public long? KillsOnOtherLanesEarlyJungleAsLaner { get; set; }

            [JsonProperty("killsOnRecentlyHealedByAramPack")]
            public long KillsOnRecentlyHealedByAramPack { get; set; }

            [JsonProperty("killsUnderOwnTurret")]
            public long KillsUnderOwnTurret { get; set; }

            [JsonProperty("killsWithHelpFromEpicMonster")]
            public long KillsWithHelpFromEpicMonster { get; set; }

            [JsonProperty("knockEnemyIntoTeamAndKill")]
            public long KnockEnemyIntoTeamAndKill { get; set; }

            [JsonProperty("landSkillShotsEarlyGame")]
            public long LandSkillShotsEarlyGame { get; set; }

            [JsonProperty("laneMinionsFirst10Minutes")]
            public long LaneMinionsFirst10Minutes { get; set; }

            [JsonProperty("laningPhaseGoldExpAdvantage")]
            public long LaningPhaseGoldExpAdvantage { get; set; }

            [JsonProperty("legendaryCount")]
            public long LegendaryCount { get; set; }

            [JsonProperty("legendaryItemUsed")]
            public List<long> LegendaryItemUsed { get; set; }

            [JsonProperty("lostAnInhibitor")]
            public long LostAnInhibitor { get; set; }

            [JsonProperty("maxCsAdvantageOnLaneOpponent")]
            public double MaxCsAdvantageOnLaneOpponent { get; set; }

            [JsonProperty("maxKillDeficit")]
            public long MaxKillDeficit { get; set; }

            [JsonProperty("maxLevelLeadLaneOpponent")]
            public long MaxLevelLeadLaneOpponent { get; set; }

            [JsonProperty("mejaisFullStackInTime")]
            public long MejaisFullStackInTime { get; set; }

            [JsonProperty("moreEnemyJungleThanOpponent")]
            public double MoreEnemyJungleThanOpponent { get; set; }

            [JsonProperty("multiKillOneSpell")]
            public long MultiKillOneSpell { get; set; }

            [JsonProperty("multiTurretRiftHeraldCount")]
            public long MultiTurretRiftHeraldCount { get; set; }

            [JsonProperty("multikills")]
            public long Multikills { get; set; }

            [JsonProperty("multikillsAfterAggressiveFlash")]
            public long MultikillsAfterAggressiveFlash { get; set; }

            [JsonProperty("outerTurretExecutesBefore10Minutes")]
            public long OuterTurretExecutesBefore10Minutes { get; set; }

            [JsonProperty("outnumberedKills")]
            public long OutnumberedKills { get; set; }

            [JsonProperty("outnumberedNexusKill")]
            public long OutnumberedNexusKill { get; set; }

            [JsonProperty("perfectDragonSoulsTaken")]
            public long PerfectDragonSoulsTaken { get; set; }

            [JsonProperty("perfectGame")]
            public long PerfectGame { get; set; }

            [JsonProperty("pickKillWithAlly")]
            public long PickKillWithAlly { get; set; }

            [JsonProperty("playedChampSelectPosition")]
            public long PlayedChampSelectPosition { get; set; }

            [JsonProperty("poroExplosions")]
            public long PoroExplosions { get; set; }

            [JsonProperty("quickCleanse")]
            public long QuickCleanse { get; set; }

            [JsonProperty("quickFirstTurret")]
            public long QuickFirstTurret { get; set; }

            [JsonProperty("quickSoloKills")]
            public long QuickSoloKills { get; set; }

            [JsonProperty("riftHeraldTakedowns")]
            public long RiftHeraldTakedowns { get; set; }

            [JsonProperty("saveAllyFromDeath")]
            public long SaveAllyFromDeath { get; set; }

            [JsonProperty("scuttleCrabKills")]
            public long ScuttleCrabKills { get; set; }

            [JsonProperty("skillshotsDodged")]
            public long SkillshotsDodged { get; set; }

            [JsonProperty("skillshotsHit")]
            public long SkillshotsHit { get; set; }

            [JsonProperty("snowballsHit")]
            public long SnowballsHit { get; set; }

            [JsonProperty("soloBaronKills")]
            public long SoloBaronKills { get; set; }

            [JsonProperty("soloKills")]
            public long SoloKills { get; set; }

            [JsonProperty("soloTurretsLategame", NullValueHandling = NullValueHandling.Ignore)]
            public long? SoloTurretsLategame { get; set; }

            [JsonProperty("stealthWardsPlaced")]
            public long StealthWardsPlaced { get; set; }

            [JsonProperty("survivedSingleDigitHpCount")]
            public long SurvivedSingleDigitHpCount { get; set; }

            [JsonProperty("survivedThreeImmobilizesInFight")]
            public long SurvivedThreeImmobilizesInFight { get; set; }

            [JsonProperty("takedownOnFirstTurret")]
            public long TakedownOnFirstTurret { get; set; }

            [JsonProperty("takedowns")]
            public long Takedowns { get; set; }

            [JsonProperty("takedownsAfterGainingLevelAdvantage")]
            public long TakedownsAfterGainingLevelAdvantage { get; set; }

            [JsonProperty("takedownsBeforeJungleMinionSpawn")]
            public long TakedownsBeforeJungleMinionSpawn { get; set; }

            [JsonProperty("takedownsFirstXMinutes")]
            public long TakedownsFirstXMinutes { get; set; }

            [JsonProperty("takedownsInAlcove")]
            public long TakedownsInAlcove { get; set; }

            [JsonProperty("takedownsInEnemyFountain")]
            public long TakedownsInEnemyFountain { get; set; }

            [JsonProperty("teamBaronKills")]
            public long TeamBaronKills { get; set; }

            [JsonProperty("teamDamagePercentage")]
            public double TeamDamagePercentage { get; set; }

            [JsonProperty("teamElderDragonKills")]
            public long TeamElderDragonKills { get; set; }

            [JsonProperty("teamRiftHeraldKills")]
            public long TeamRiftHeraldKills { get; set; }

            [JsonProperty("tookLargeDamageSurvived")]
            public long TookLargeDamageSurvived { get; set; }

            [JsonProperty("turretPlatesTaken")]
            public long TurretPlatesTaken { get; set; }

            [JsonProperty("turretTakedowns")]
            public long TurretTakedowns { get; set; }

            [JsonProperty("turretsTakenWithRiftHerald")]
            public long TurretsTakenWithRiftHerald { get; set; }

            [JsonProperty("twentyMinionsIn3SecondsCount")]
            public long TwentyMinionsIn3SecondsCount { get; set; }

            [JsonProperty("twoWardsOneSweeperCount")]
            public long TwoWardsOneSweeperCount { get; set; }

            [JsonProperty("unseenRecalls")]
            public long UnseenRecalls { get; set; }

            [JsonProperty("visionScoreAdvantageLaneOpponent")]
            public double VisionScoreAdvantageLaneOpponent { get; set; }

            [JsonProperty("visionScorePerMinute")]
            public double VisionScorePerMinute { get; set; }

            [JsonProperty("voidMonsterKill")]
            public long VoidMonsterKill { get; set; }

            [JsonProperty("wardTakedowns")]
            public long WardTakedowns { get; set; }

            [JsonProperty("wardTakedownsBefore20M")]
            public long WardTakedownsBefore20M { get; set; }

            [JsonProperty("wardsGuarded")]
            public long WardsGuarded { get; set; }

            [JsonProperty("highestCrowdControlScore", NullValueHandling = NullValueHandling.Ignore)]
            public long? HighestCrowdControlScore { get; set; }

            [JsonProperty("junglerKillsEarlyJungle", NullValueHandling = NullValueHandling.Ignore)]
            public long? JunglerKillsEarlyJungle { get; set; }

            [JsonProperty("killsOnLanersEarlyJungleAsJungler", NullValueHandling = NullValueHandling.Ignore)]
            public long? KillsOnLanersEarlyJungleAsJungler { get; set; }

            [JsonProperty("controlWardTimeCoverageInRiverOrEnemyHalf", NullValueHandling = NullValueHandling.Ignore)]
            public double? ControlWardTimeCoverageInRiverOrEnemyHalf { get; set; }

            [JsonProperty("firstTurretKilledTime", NullValueHandling = NullValueHandling.Ignore)]
            public double? FirstTurretKilledTime { get; set; }

            [JsonProperty("teleportTakedowns", NullValueHandling = NullValueHandling.Ignore)]
            public long? TeleportTakedowns { get; set; }

            [JsonProperty("earliestDragonTakedown", NullValueHandling = NullValueHandling.Ignore)]
            public double? EarliestDragonTakedown { get; set; }

            [JsonProperty("shortestTimeToAceFromFirstTakedown", NullValueHandling = NullValueHandling.Ignore)]
            public double? ShortestTimeToAceFromFirstTakedown { get; set; }

            [JsonProperty("highestChampionDamage", NullValueHandling = NullValueHandling.Ignore)]
            public long? HighestChampionDamage { get; set; }

            [JsonProperty("highestWardKills", NullValueHandling = NullValueHandling.Ignore)]
            public long? HighestWardKills { get; set; }
        }

        public partial class Perks
        {
            [JsonProperty("statPerks")]
            public StatPerks StatPerks { get; set; }

            [JsonProperty("styles")]
            public List<Style> Styles { get; set; }
        }

        public partial class StatPerks
        {
            [JsonProperty("defense")]
            public long Defense { get; set; }

            [JsonProperty("flex")]
            public long Flex { get; set; }

            [JsonProperty("offense")]
            public long Offense { get; set; }
        }

        public partial class Style
        {
            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("selections")]
            public List<Selection> Selections { get; set; }

            [JsonProperty("style")]
            public long StyleStyle { get; set; }
        }

        public partial class Selection
        {
            [JsonProperty("perk")]
            public long Perk { get; set; }

            [JsonProperty("var1")]
            public long Var1 { get; set; }

            [JsonProperty("var2")]
            public long Var2 { get; set; }

            [JsonProperty("var3")]
            public long Var3 { get; set; }
        }

        public partial class Team
        {
            [JsonProperty("bans")]
            public List<Ban> Bans { get; set; }

            [JsonProperty("objectives")]
            public Objectives Objectives { get; set; }

            [JsonProperty("teamId")]
            public long TeamId { get; set; }

            [JsonProperty("win")]
            public bool Win { get; set; }
        }

        public partial class Ban
        {
            [JsonProperty("championId")]
            public long ChampionId { get; set; }

            [JsonProperty("pickTurn")]
            public long PickTurn { get; set; }
        }

        public partial class Objectives
        {
            [JsonProperty("baron")]
            public Baron Baron { get; set; }

            [JsonProperty("champion")]
            public Baron Champion { get; set; }

            [JsonProperty("dragon")]
            public Baron Dragon { get; set; }

            [JsonProperty("horde")]
            public Baron Horde { get; set; }

            [JsonProperty("inhibitor")]
            public Baron Inhibitor { get; set; }

            [JsonProperty("riftHerald")]
            public Baron RiftHerald { get; set; }

            [JsonProperty("tower")]
            public Baron Tower { get; set; }
        }

        public partial class Baron
        {
            [JsonProperty("first")]
            public bool First { get; set; }

            [JsonProperty("kills")]
            public long Kills { get; set; }
        }

        public partial class Metadata
        {
            [JsonProperty("dataVersion")]
            public long DataVersion { get; set; }

            [JsonProperty("matchId")]
            public string MatchId { get; set; }

            //[JsonProperty("participants")]
            //public List<string> Participants { get; set; }
        }



}
