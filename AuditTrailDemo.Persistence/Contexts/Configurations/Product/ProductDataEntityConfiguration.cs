namespace AuditTrailDemo.Persistence.Contexts.Configurations.Product
{
    using AuditTrailDemo.Persistence.DataEntities.Product;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ProductDataEntityConfiguration : IEntityTypeConfiguration<ProductDataEntity>
    {
        public void Configure(EntityTypeBuilder<ProductDataEntity> builder)
        {
            builder
               .HasKey(productDataEntity => productDataEntity.Id);

            builder
               .Property(productDataEntity => productDataEntity.Name)
               .IsRequired();

            builder
               .Property(productDataEntity => productDataEntity.Price)
               .IsRequired();

            builder
               .Property(productDataEntity => productDataEntity.Quantity)
               .IsRequired();
        }
    }
}
