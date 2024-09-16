using System.ComponentModel;

namespace TheatricalPlayers.Domain.Interfaces;

public interface IType
{
    public double Value { get; set; }
    public double CalculateValue(int audience, double baseValue);
    public int CalculateCreditType(int audience);
}
