namespace TheatricalPlayersRefactoringKata;

public class Invoice
{
    public string Customer { get; set; }
    public List<Performance> Performances { get; set; }

    public Invoice(string customer, List<Performance> performances)
    {
        Customer = customer;
        Performances = performances;
    }
    public List<double> CalculateValues()
    {
        return Performances.Select(perf => CalculateAmount(perf)).ToList();
    }

    public List<int> CalculateCredits()
    {
        return new List<int>();
    }

    private static double CalculateAmount(Performance perf)
    {
        var play = perf.Play;
        var lines = Clamp(play.Lines, 1000, 4000);
        var baseAmount = lines / 10.0;
        var finalAmount = play.Type.CalculateValue(perf.Audience, baseAmount);

        return finalAmount;
    }

    private static int Clamp(int value, int min, int max)
    {
        if (value < min) return min;
        if (value > max) return max;
        return value;
    }

}

