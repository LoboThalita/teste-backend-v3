using System.ComponentModel.DataAnnotations;
using TheatricalPlayers.Domain.Interfaces;

namespace TheatricalPlayersRefactoringKata;

public class Invoice : IInvoice
{
    public string Customer { get; set; }
    public List<IPerformance> Performances { get; set; }
}

