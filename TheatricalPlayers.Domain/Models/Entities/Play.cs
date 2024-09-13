using TheatricalPlayers.Domain.Interfaces;

namespace TheatricalPlayersRefactoringKata;

public class Play
{
    public Play(string name, int lines, IType type)
    {
        Name = name;
        Lines = lines;
        Type = type;
    }

    public int PlayId { get; set; }
    public string Name { get; }
    public int Lines { get; }
    public IType Type { get; }
    public decimal BaseValue => Lines / 10;
}
