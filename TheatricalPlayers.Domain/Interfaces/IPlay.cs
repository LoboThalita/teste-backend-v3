namespace TheatricalPlayers.Domain.Interfaces;

public interface IPlay
{
    public string Name { get; }
    public int Lines { get; }
    public IType Type { get; }
}
