using TheatricalPlayers.Domain.Interfaces;

namespace TheatricalPlayers.Domain.Models.Types;

public class Historical : IType
{
    public double Value { get; set; }

    public double CalculateValue(int audience, double baseValue)
    {
        Value = audience <= 30 ? baseValue : baseValue + (audience - 30) * 10.00;

        baseValue += 3.00 * audience;
        Value += audience > 20 ? baseValue + 100.00 + (audience - 20) * 5.00 : baseValue;
        return Value;
    }
}
