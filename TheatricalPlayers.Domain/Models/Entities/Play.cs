using TheatricalPlayers.Domain.Interfaces;
using TheatricalPlayers.Domain.Interfaces.Services;

namespace TheatricalPlayersRefactoringKata;

public class Play
{
    public Play(string name, int lines, IType type)
    {
        Name = name;
        Lines = lines;
        Type = type;
    }

    public string Name { get; }
    public int Lines { get; }
    public IType Type { get; }
}
