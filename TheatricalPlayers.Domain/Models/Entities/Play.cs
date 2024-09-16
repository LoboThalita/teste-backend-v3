using System.ComponentModel.DataAnnotations;
using TheatricalPlayers.Domain.Factories;
using TheatricalPlayers.Domain.Interfaces;
using TheatricalPlayers.Domain.Models.Enum;

namespace TheatricalPlayersRefactoringKata;

public class Play : IPlay
{
    public string Name { get; }

    public int Lines { get; }

    public IType Type { get; }
}
