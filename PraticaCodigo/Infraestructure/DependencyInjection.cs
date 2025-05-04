using Microsoft.EntityFrameworkCore;
using PraticaCodigo.Models.Orders;
using PraticaCodigo.Repositories;
using PraticaCodigo.Services;

namespace PraticaCodigo.Infraestructure;

public static class DependencyInjection
{
    public static IServiceCollection AddAplicationServices(this IServiceCollection services)
    {
        var databaseConfig = new DatabaseConfig();

        services.AddSingleton(databaseConfig);

        services.AddDbContext<DatabaseContext>(options =>
            options.UseSqlite($"Data Source={databaseConfig.DbPath}"));

        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IOrderService, OrderService>();

        services.AddSwaggerGen();

        return services;
    } 
}
