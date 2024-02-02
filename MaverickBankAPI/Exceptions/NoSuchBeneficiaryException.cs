using System.Runtime.Serialization;

namespace MaverickBankAPI.Exceptions
{
    [Serializable]
    internal class NoSuchBeneficiaryException : Exception
    {
        public NoSuchBeneficiaryException()
        {
        }

        public NoSuchBeneficiaryException(string? message) : base(message)
        {
        }

        public NoSuchBeneficiaryException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoSuchBeneficiaryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}