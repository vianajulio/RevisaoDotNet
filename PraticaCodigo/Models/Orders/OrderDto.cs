using PraticaCodigo.Models.ItemsOrders;

namespace PraticaCodigo.Models.Orders;

public record OrderDto(string ClientName, IEnumerable<ItemDto> Items);
