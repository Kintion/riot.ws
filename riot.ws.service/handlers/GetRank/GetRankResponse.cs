

namespace riot.ws.service.handlers.GetRank
{
    public class GetRankResponse
    {
        public string LeagueId { get; set; }        // ID único de la liga
        public string QueueType { get; set; }      // Tipo de cola (RANKED_FLEX_SR o RANKED_SOLO_5x5)
        public string Tier { get; set; }           // Nivel (Platinum, Emerald, etc.)
        public string Rank { get; set; }           // Rango dentro del nivel (I, II, III, etc.)
        public string SummonerId { get; set; }     // ID único del invocador asociado
        public int LeaguePoints { get; set; }      // Puntos de liga actuales
        public int Wins { get; set; }              // Número de victorias
        public int Losses { get; set; }            // Número de derrotas
        public bool Veteran { get; set; }          // ¿Es veterano en la liga?
        public bool Inactive { get; set; }         // ¿Está inactivo?
        public bool FreshBlood { get; set; }       // ¿Es sangre nueva (recién ascendido)?
        public bool HotStreak { get; set; }
    }
}
