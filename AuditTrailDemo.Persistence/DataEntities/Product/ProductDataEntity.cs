namespace AuditTrailDemo.Persistence.DataEntities.Product
{
    using System;

    public class ProductDataEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
