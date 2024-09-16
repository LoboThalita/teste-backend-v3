namespace TheatricalPlayers.Domain.Interfaces;

public interface IPerformance
{
    public IPlay Play { get; }
    public int Audience { get; }
    public double CalculateValue();
    public int CalculateCredits();
}
