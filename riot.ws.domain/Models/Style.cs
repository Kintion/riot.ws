

namespace riot.ws.domain.Models;

public partial class Style
{
    public int Id { get; set; }

    public int PerkId { get; set; }

    public string Description { get; set; } = null!;

    public int Style1 { get; set; }

    public virtual Perk Perk { get; set; } = null!;

    public virtual ICollection<Selection> Selections { get; set; } = new List<Selection>();
}
