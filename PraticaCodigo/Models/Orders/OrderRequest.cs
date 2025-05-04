using PraticaCodigo.Models.ItemsOrders;

namespace PraticaCodigo.Models.Orders;

public record OrderRequest(string ClientName, IEnumerable<ItemRequest> Items);
