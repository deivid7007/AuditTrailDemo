namespace AuditTrailDemo.Domain.Aggregates
{
    using AuditTrailDemo.Domain.Exceptions.Product;
    using System;

    public class ProductAggregate
    {
        public ProductAggregate() {}

        public ProductAggregate(
            Guid id,
            string name,
            int quantity,
            decimal price)
        {
            if (string.IsNullOrEmpty(name) || name.Length <= 1)
            {
                throw new InvalidProductNameException("Ivalid product name!");
            }

            this.Name = name;

            if (quantity < 0)
            {
                throw new InvalidProductQuantityException("Invalid product quantity!");
            }

            this.Quantity = quantity;

            if (price < 0m)
            {
                throw new InvalidProductPriceException("Ivalid product price!");
            }

            this.Price = price;
        }

        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public int Quantity { get; private set; }

        public decimal Price { get; private set; }
    }
}
