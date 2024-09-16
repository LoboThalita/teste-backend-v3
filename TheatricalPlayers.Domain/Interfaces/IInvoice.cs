namespace TheatricalPlayers.Domain.Interfaces;

public interface IInvoice
{
    public string Customer { get; set; }
    public List<IPerformance> Performances { get; set; }
}
