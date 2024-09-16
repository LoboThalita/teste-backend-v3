using Microsoft.Extensions.DependencyInjection;
using TheatricalPlayers.Domain.Interfaces;
using TheatricalPlayers.Domain.Models.Types;

namespace TheatricalPlayers.Domain.Factories;

public class TypeFactory
{
    private readonly IServiceProvider _serviceProvider;

    public TypeFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IType Create(string typeName)
    {
        switch (typeName)
        {
            case "Comedy":
                return _serviceProvider.GetRequiredService<Comedy>();
            case "Tragedy":
                return _serviceProvider.GetRequiredService<Tragedy>();
            default:
                throw new ArgumentException("Invalid type name", nameof(typeName));
        }
    }
}

