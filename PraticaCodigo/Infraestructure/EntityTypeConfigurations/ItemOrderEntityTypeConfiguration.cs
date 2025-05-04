using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PraticaCodigo.Models.ItemsOrders;

namespace PraticaCodigo.Infraestructure.EntityTypeConfigurations;

public class ItemOrderEntityTypeConfiguration : IEntityTypeConfiguration<ItemOrder>
{
    public void Configure(EntityTypeBuilder<ItemOrder> builder)
    {
        builder.ToTable("ItemsOrder");

        builder.HasKey(i => i.Id);

        builder.Property(i => i.ProductName)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(i => i.Price)
            .HasColumnType("decimal(18,2)");
    }
}
