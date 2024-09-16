namespace TheatricalPlayers.Domain.Models.Types;

public class CreditType
{
    public virtual int CalculateCreditType(int audience)
    {
        if (audience > 30)
        {
            return audience - 30;
        }

        return 0;
    }
}
