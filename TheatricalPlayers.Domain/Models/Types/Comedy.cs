using TheatricalPlayers.Domain.Interfaces;

namespace TheatricalPlayers.Domain.Models.Types;

public class Comedy : IType
{
    public double Value { get; set;  }

    const int maxAudience = 20;
    const double additionalValue = 5.00;
    public void CalculateValue(int audience, double baseValue)
    {
        baseValue += 3.00 * audience;

        Value = audience > maxAudience ? baseValue +  100.00 + (audience - maxAudience) * additionalValue : baseValue;
    }
}
