using System.Runtime.Serialization;

namespace MaverickBankAPI.Repositories
{
    [Serializable]
    internal class NoSuchAccountException : Exception
    {
        public NoSuchAccountException()
        {
        }

        public NoSuchAccountException(string? message) : base(message)
        {
        }

        public NoSuchAccountException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoSuchAccountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}