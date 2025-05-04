using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PraticaCodigo.Models.Orders;

namespace PraticaCodigo.Infraestructure.EntityConfigurations;

public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders");

        builder.HasKey(o =>  o.Id);

        builder.Property(o => o.ClientName)
                .HasMaxLength(150)
                .IsRequired();

        builder.Ignore(o => o.TotalValue);

        builder.HasMany(o => o.Items)
                .WithOne(i => i.Order)
                .HasForeignKey(i => i.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
    }
}
