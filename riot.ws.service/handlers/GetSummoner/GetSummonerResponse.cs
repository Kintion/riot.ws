
namespace riot.ws.service.handlers.GetSummoner
{
    public class GetSummonerResponse
    {
        public string Id { get; set; }                // ID único del invocador
        public string AccountId { get; set; }        // ID asociado a la cuenta
        public string Puuid { get; set; }            // Identificador único global
        public int ProfileIconId { get; set; }       // ID del ícono de perfil seleccionado
        public long RevisionDate { get; set; }       // Fecha de la última modificación (en timestamp UNIX)
        public int SummonerLevel { get; set; }       // Nivel actual del invocador
    }
}
