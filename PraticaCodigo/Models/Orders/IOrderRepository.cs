namespace PraticaCodigo.Models.Orders;

public interface IOrderRepository
{
    Task<bool> CreateAsync(Order order);
}
