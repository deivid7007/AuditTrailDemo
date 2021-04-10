namespace AuditTrailDemo.Domain.Exceptions.Product
{
    using System;

    public class InvalidProductPriceException : Exception
    {
        public InvalidProductPriceException()
        {
        }

        public InvalidProductPriceException(string message)
            : base(message)
        {
        }

        public InvalidProductPriceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
