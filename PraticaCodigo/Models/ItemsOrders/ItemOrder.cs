using PraticaCodigo.Models.Orders;

namespace PraticaCodigo.Models.ItemsOrders;

public class ItemOrder
{
    public Guid Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public Guid OrderId { get; set; }
    public Order Order { get; set; } = null!;

    protected ItemOrder() { }

    public ItemOrder(string productName, int quantity, decimal price)
    {
        Id = Guid.NewGuid();
        ProductName = productName;
        Quantity = quantity;
        Price = price;
    }


    public static ItemOrder Create(string productName, int quantity, decimal price)
    {
        ValidateItemOrder(productName, quantity, price);
        return new ItemOrder(productName, quantity, price);
    }

    public static List<ItemOrder> CreateItemsOrder(IEnumerable<ItemDto> items)
        => items.Select(i => Create(i.productName, i.quantity, i.price)).ToList();


    private static void ValidateItemOrder(string productName, int quantity, decimal price)
    {
        if (string.IsNullOrEmpty(productName))
        {
            throw new ArgumentNullException("Nome do produto não pode ser vázio.", nameof(productName));
        }

        if (quantity <= 0)
        {
            throw new ArgumentException("Quantidade precisa ser maior que zero.", nameof(quantity));
        }

        if (quantity <= 0)
        {
            throw new ArgumentException("Valor precisa ser maior que zero.", nameof(price));
        }
    }
}
