using TheatricalPlayers.Domain.Interfaces;
using TheatricalPlayers.Domain.Models.Enum;

namespace TheatricalPlayers.Domain.Models.Types;

public class Historical : CreditType, IType
{
    public TypeEnum TypeEnum { get; set; }
    public double Value { get; set; }

    public double CalculateValue(int audience, double baseValue)
    {
        Value = audience <= 30 ? baseValue : baseValue + (audience - 30) * 10.00;

        baseValue += 3.00 * audience;
        Value += audience > 20 ? baseValue + 100.00 + (audience - 20) * 5.00 : baseValue;
        return Value;
    }
}
