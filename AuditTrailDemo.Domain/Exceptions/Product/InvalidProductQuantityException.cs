namespace AuditTrailDemo.Domain.Exceptions.Product
{
    using System;

    public class InvalidProductQuantityException : Exception
    {
        public InvalidProductQuantityException()
        {
        }

        public InvalidProductQuantityException(string message)
            : base(message)
        {
        }

        public InvalidProductQuantityException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
