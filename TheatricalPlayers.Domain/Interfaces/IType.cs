using TheatricalPlayers.Domain.Models.Enum;

namespace TheatricalPlayers.Domain.Interfaces;

public interface IType
{
    public TypeEnum TypeEnum { get; set; }
    public double Value { get; set; }
    public double CalculateValue(int audience, double baseValue);
    public int CalculateCreditType(int audience);
}
