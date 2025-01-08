
namespace riot.ws.domain.Models;

public partial class Selection
{
    public int Id { get; set; }

    public int StyleId { get; set; }

    public int Perk { get; set; }

    public int Var1 { get; set; }

    public int Var2 { get; set; }

    public int Var3 { get; set; }

    public virtual Style Style { get; set; } = null!;
}
