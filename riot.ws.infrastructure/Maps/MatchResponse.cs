using riot.ws.infrastructure.dto;

namespace riot.ws.infrastructure.Maps
{
    public class MatchResponse
    {
        public string Matchid { get; set; } = null!;

        public string Gameversion { get; set; } = null!;

        public int Queueid { get; set; }

        public string Platformid { get; set; } = null!;

        public int Teamidwin { get; set; }

        public long Duracion { get; set; }

        public DateTime Fechafinalizacion { get; set; }
        public virtual List<ParticipanteDto> Participantes { get; set; } = new List<ParticipanteDto>();

    }
}
