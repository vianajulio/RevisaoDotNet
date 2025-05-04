using PraticaCodigo.Models.ItemsOrders;
using PraticaCodigo.Models.Orders;

namespace PraticaCodigo.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<bool> CreateAsync(OrderDto orderRequest)
    {
        var itemsOrder = ItemOrder.CreateItemsOrder(orderRequest.Items);
        var order = Order.Create(orderRequest.ClientName, itemsOrder);
        try
        {
            await _orderRepository.CreateAsync(order);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return false;
        }

        return true;
    }
}
