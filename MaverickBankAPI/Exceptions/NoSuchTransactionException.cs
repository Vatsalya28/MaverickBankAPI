using System.Runtime.Serialization;

namespace MaverickBankAPI.Repositories
{
    [Serializable]
    internal class NoSuchTransactionException : Exception
    {
        public NoSuchTransactionException()
        {
        }

        public NoSuchTransactionException(string? message) : base(message)
        {
        }

        public NoSuchTransactionException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoSuchTransactionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}