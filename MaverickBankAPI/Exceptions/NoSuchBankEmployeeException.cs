using System.Runtime.Serialization;

namespace MaverickBankAPI.Exceptions
{
    [Serializable]
    internal class NoSuchBankEmployeeException : Exception
    {
        public NoSuchBankEmployeeException()
        {
        }

        public NoSuchBankEmployeeException(string? message) : base(message)
        {
        }

        public NoSuchBankEmployeeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoSuchBankEmployeeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}