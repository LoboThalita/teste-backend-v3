using System;
using System.Collections.Generic;
using System.Globalization;
using TheatricalPlayers.Domain.Interfaces;
using TheatricalPlayers.Domain.Models.Enum;
using TheatricalPlayersRefactoringKata;
using Xunit;

public class InvoiceTests
{
    public class MockType : IType
    {
        public TypeEnum TypeEnum { get; set; }
        public double Value { get; set; }

        public double CalculateValue(int audience, double baseValue)
        {
            return baseValue + (audience * Value);
        }

        public int CalculateCreditType(int audience)
        {
            return audience > 30 ? audience - 30 : 0;
        }
    }

    public class MockPlay : IPlay
    {
        public string Name { get; set; }
        public int Lines { get; set; }
        public IType Type { get; set; }
    }

    public class MockPerformance : IPerformance
    {
        public IPlay Play { get; set; }
        public int Audience { get; set; }

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

    [Fact]
    public void Print_ValidInvoice_ReturnsCorrectStatement()
    {
        var invoice = new Invoice
        {
            Customer = "John Doe",
            Performances = new List<IPerformance>
            {
                new MockPerformance
                {
                    Play = new MockPlay
                    {
                        Name = "Hamlet",
                        Lines = 1500,
                        Type = new MockType
                        {
                            TypeEnum = TypeEnum.Tragedy,
                            Value = 5.0
                        }
                    },
                    Audience = 55
                },
                new MockPerformance
                {
                    Play = new MockPlay
                    {
                        Name = "As You Like It",
                        Lines = 2000,
                        Type = new MockType
                        {
                            TypeEnum = TypeEnum.Comedy,
                            Value = 3.0
                        }
                    },
                    Audience = 35
                }
            }
        };

        var expected =
            "Statement for John Doe\n" +
            "  Hamlet: $275.00 (55 seats)\n" +
            "  As You Like It: $235.00 (35 seats)\n" +
            "Amount owed is $510.00\n" +
            "You earned 30 credits\n";

        var result = Print(invoice);

        Assert.Equal(expected, result);
    }

    public string Print(Invoice invoice)
    {
        var result = string.Format("Statement for {0}\n", invoice.Customer);
        CultureInfo cultureInfo = new CultureInfo("en-US");

        var totalAmount = 0.0;
        var volumeCredits = 0;

        foreach (var perf in invoice.Performances)
        {
            var thisAmount = perf.CalculateValue();
            var credit = perf.CalculateCredits();

            volumeCredits += credit;

            result += string.Format(cultureInfo, "  {0}: {1:C} ({2} seats)\n", perf.Play.Name, Convert.ToDecimal(thisAmount / 100), perf.Audience);
            totalAmount += thisAmount;
        }
        result += string.Format(cultureInfo, "Amount owed is {0:C}\n", Convert.ToDecimal(totalAmount / 100));
        result += string.Format("You earned {0} credits\n", volumeCredits);
        return result;
    }
}
