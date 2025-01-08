

namespace riot.ws.domain.Models;

public partial class Perk
{
    public int Id { get; set; }

    public int Defense { get; set; }

    public int Flex { get; set; }

    public int Offense { get; set; }

    public virtual ICollection<Style> Styles { get; set; } = new List<Style>();
}
