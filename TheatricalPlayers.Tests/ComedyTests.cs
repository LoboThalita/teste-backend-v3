using TheatricalPlayers.Domain.Models.Types;
using Xunit;

namespace TheatricalPlayers.Tests;

public class ComedyTests
{
    [Theory]
    [InlineData(100,1000.0, 1800.0)]
    public void CalculateValue_ShouldReturnExpectedValue(int audience, double basevalue,  double expected)
    {
        var comedy = new Comedy();

        double result = comedy.CalculateValue(audience, basevalue);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 2)]  
    [InlineData(5, 1)]  
    [InlineData(20, 4)]  
    public void CalculateCreditType_ShouldReturnExpectedCredits(int audience, int expectedBonus)
    {
        var comedy = new Comedy();

        int result = comedy.CalculateCreditType(audience);

        Assert.Equal(expectedBonus, result);
    }
}
