using System.Runtime.Serialization;

namespace MaverickBankAPI.Exceptions
{
    [Serializable]
    internal class NoSuchAdministratorException : Exception
    {
        public NoSuchAdministratorException()
        {
        }

        public NoSuchAdministratorException(string? message) : base(message)
        {
        }

        public NoSuchAdministratorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoSuchAdministratorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}