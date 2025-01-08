

namespace riot.ws.domain.Models;

public partial class SummonerAccount
{
    public string Puuid { get; set; } = null!;

    public string Gamename { get; set; } = null!;

    public string Tagline { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string Summonerid { get; set; } = null!;

    public int Profileiconid { get; set; }

    public DateTime Revisiondate { get; set; }

    public int Summonerlevel { get; set; }

    public virtual ICollection<Participante> Participantes { get; set; } = new List<Participante>();

    public virtual ICollection<RankEntity> Ranks { get; set; } = new List<RankEntity>();
}
