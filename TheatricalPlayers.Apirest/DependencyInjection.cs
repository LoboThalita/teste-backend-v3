using Microsoft.Extensions.DependencyInjection;
using TheatricalPlayers.Application.Services;
using TheatricalPlayers.Domain.Factories;
using TheatricalPlayers.Domain.Interfaces;
using TheatricalPlayers.Domain.Interfaces.Services;
using TheatricalPlayers.Domain.Models.Types;
using TheatricalPlayersRefactoringKata;

namespace TheatricalPlayers.Apirest;

public static class DependencyInjection
{
    public static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        services.AddScoped<IInvoiceService, InvoiceService>();
        services.AddScoped<ITypeService, TypeService>();
        services.AddScoped<IPlay, Play>();
        services.AddScoped<IPerformance, Performance>();
        services.AddScoped<IInvoice, Invoice>();

        services.AddScoped<Comedy>();
        services.AddScoped<Tragedy>();
        services.AddScoped<Historical>();

        services.AddScoped<TypeFactory>();

        return services;
    }
}
