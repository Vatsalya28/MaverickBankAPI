using System.Runtime.Serialization;

namespace MaverickBankAPI.Repsitories
{
    [Serializable]
    internal class NoSuchCustomerException : Exception
    {

        string message;
        public NoSuchCustomerException()
        {
            message = "No such customer with the given id";
        }
        public override string Message => base.Message;


    }
}