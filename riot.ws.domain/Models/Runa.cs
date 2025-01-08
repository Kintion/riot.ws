
namespace riot.ws.domain.Models;

public partial class Runa
{
    public string Matchid { get; set; } = null!;

    public int Championid { get; set; }

    public int Selectionid { get; set; }

    public virtual Partida Match { get; set; } = null!;
}
