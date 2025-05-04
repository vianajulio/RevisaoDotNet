using PraticaCodigo.Models.ItemsOrders;

namespace PraticaCodigo.Models.Orders;

public class Order
{
    public Guid Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string ClientName { get; set; } = string.Empty;
    public List<ItemOrder> Items { get; set; } = new();
    public decimal TotalValue => Items.Sum(i => i.Price * i.Quantity);

    protected Order() { }

    public Order(string clientName, List<ItemOrder> items)
    {
        Id = Guid.NewGuid();
        ClientName = clientName;
        Items = items;
        CreatedDate = DateTime.Now;
    }

    public static Order Create(string clientName, List<ItemOrder> items)
    {
        ValidateOrder(clientName, items);
        return new Order(clientName, items);
    }

    private static void ValidateOrder(string clientName, List<ItemOrder> items)
    {
        if (string.IsNullOrEmpty(clientName))
        {
            throw new ArgumentNullException("Nome do cliente não pode ser vazio.", nameof(clientName));
        }

        if (!items.Any())
        {
            throw new ArgumentNullException("Lista de itens não pode ser vazia.", nameof(items));
        }
    }
}
