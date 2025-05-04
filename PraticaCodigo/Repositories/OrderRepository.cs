using PraticaCodigo.Infraestructure;
using PraticaCodigo.Models.Orders;

namespace PraticaCodigo.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly DatabaseContext _dbContext;

    public OrderRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CreateAsync(Order order)
    {
        await _dbContext.Orders.AddAsync(order);
        var result = await _dbContext.SaveChangesAsync();
        return result > 0;
    }
}
