namespace PraticaCodigo.Models.Orders;

public interface IOrderService
{
    Task<bool> CreateAsync(OrderDto orderRequest);
}
