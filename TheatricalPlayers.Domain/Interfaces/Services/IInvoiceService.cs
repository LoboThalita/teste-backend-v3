using System.Xml.Linq;
using TheatricalPlayersRefactoringKata;

namespace TheatricalPlayers.Domain.Interfaces.Services;

public interface IInvoiceService
{
    public string Print(Invoice invoice);
    public XDocument PrintXML(Invoice invoice);
}
