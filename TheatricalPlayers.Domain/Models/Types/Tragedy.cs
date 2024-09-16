using TheatricalPlayers.Domain.Interfaces;
using TheatricalPlayers.Domain.Models.Enum;

namespace TheatricalPlayers.Domain.Models.Types;

public class Tragedy : CreditType, IType
{
    public TypeEnum TypeEnum { get; set; }
    public double Value { get; set; }

    const int maxAudience = 30;
    const double additionalValue = 10.00;

    public double CalculateValue(int audience, double baseValue)
    {
        Value = audience <= maxAudience ? baseValue : baseValue + (audience- maxAudience) * additionalValue;
        return Value;
    }
}
