using System.Globalization;
using System.Xml.Linq;
using TheatricalPlayers.Domain.Interfaces.Services;
using TheatricalPlayersRefactoringKata;

namespace TheatricalPlayers.Application.Services;

public class InvoiceService : IInvoiceService
{

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

            result += String.Format(cultureInfo, "  {0}: {1:C} ({2} seats)\n", perf.Play.Name, Convert.ToDecimal(thisAmount / 100), perf.Audience);
            totalAmount += thisAmount;
        }
        result += String.Format(cultureInfo, "Amount owed is {0:C}\n", Convert.ToDecimal(totalAmount / 100));
        result += String.Format("You earned {0} credits\n", volumeCredits);
        return result;
    }

    public XDocument PrintXML(Invoice invoice)
    {
        XDocument xmlDoc = new XDocument(
            new XElement(invoice.Customer,
                new XElement("Child1", "Value1"),
                new XElement("Child2", "Value2")  
            )
        );

        return xmlDoc;
    }
}
