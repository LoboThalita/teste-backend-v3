using System.ComponentModel.DataAnnotations;
using TheatricalPlayers.Domain.Interfaces;

namespace TheatricalPlayersRefactoringKata;

public class Performance : IPerformance
{
    public IPlay Play { get; }

    public int Audience { get; }

    public double CalculateValue()
    {
        int lines = Math.Clamp(Play.Lines, 1000, 4000);
        double baseAmount = lines / 10.0;
        return Play.Type.CalculateValue(Audience, baseAmount);
    }

    public int CalculateCredits()
    {
        return Play.Type.CalculateCreditType(Audience);
    }
}


