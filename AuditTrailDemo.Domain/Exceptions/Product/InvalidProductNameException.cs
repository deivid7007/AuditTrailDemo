namespace AuditTrailDemo.Domain.Exceptions.Product
{
    using System;

    public class InvalidProductNameException : Exception
    {
        public InvalidProductNameException()
        {
        }

        public InvalidProductNameException(string message)
            : base(message)
        {
        }

        public InvalidProductNameException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
