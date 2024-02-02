using System.Runtime.Serialization;

namespace MaverickBankAPI.Exceptions
{
    [Serializable]
    internal class NoSuchBankException : Exception
    {
        public NoSuchBankException()
        {
        }

        public NoSuchBankException(string? message) : base(message)
        {
        }

        public NoSuchBankException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoSuchBankException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}