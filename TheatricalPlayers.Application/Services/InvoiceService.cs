using System.Xml.Linq;
using TheatricalPlayers.Domain.Interfaces.Services;
using TheatricalPlayersRefactoringKata;

namespace TheatricalPlayers.Application.Services;

public class InvoiceService : IInvoiceService
{
    public string Print(Invoice invoice)
    {
        throw new NotImplementedException();
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
