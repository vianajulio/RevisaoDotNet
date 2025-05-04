using Microsoft.AspNetCore.Mvc;
using PraticaCodigo.Models.Orders;

namespace PraticaCodigo.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;
    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder(OrderRequest order)
    {
        var result = await _orderService.CreateAsync(order);

        if (result)
        {
            return Ok();
        }

        return BadRequest();
    }
}
