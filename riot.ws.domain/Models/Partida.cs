

namespace riot.ws.domain.Models;

public partial class Partida
{
    public string Matchid { get; set; } = null!;

    public string Gameversion { get; set; } = null!;

    public int Queueid { get; set; }

    public string Platformid { get; set; } = null!;

    public int Teamidwin { get; set; }

    public long Duracion { get; set; }

    public DateTime Fechafinalizacion { get; set; }

    public virtual ICollection<Participante> Participantes { get; set; } = new List<Participante>();

    //public virtual ICollection<Runa> Runas { get; set; } = new List<Runa>();

    //Nos faltarian los picks y bans
}
