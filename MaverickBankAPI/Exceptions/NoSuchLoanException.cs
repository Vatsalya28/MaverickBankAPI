using System.Runtime.Serialization;

namespace MaverickBankAPI.Exceptions
{
    [Serializable]
    internal class NoSuchLoanException : Exception
    {
        public NoSuchLoanException()
        {
        }

        public NoSuchLoanException(string? message) : base(message)
        {
        }

        public NoSuchLoanException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoSuchLoanException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}