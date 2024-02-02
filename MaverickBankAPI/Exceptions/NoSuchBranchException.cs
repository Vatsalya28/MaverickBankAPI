using System.Runtime.Serialization;

namespace MaverickBankAPI.Repositories
{
    [Serializable]
    internal class NoSuchBranchException : Exception
    {
        public NoSuchBranchException()
        {
        }

        public NoSuchBranchException(string? message) : base(message)
        {
        }

        public NoSuchBranchException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoSuchBranchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}