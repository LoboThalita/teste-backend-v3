namespace TheatricalPlayers.Domain.Models.Types;

public class CreditType
{
    public virtual int CalculateCreditType(int audience)
    {
        return Math.Max(audience - 30, 0);
    }
}
