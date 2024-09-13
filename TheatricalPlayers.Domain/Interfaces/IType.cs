using System.ComponentModel;

namespace TheatricalPlayers.Domain.Interfaces;

public interface IType
{
    public double Value { get; set; }
    public void CalculateValue(int audience, double baseValue);
}
