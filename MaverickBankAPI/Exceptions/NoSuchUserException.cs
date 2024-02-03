using System.Runtime.Serialization;

namespace MaverickBankAPI.Repositories
{
    [Serializable]
    internal class NoSuchUserException : Exception
    {
        string message;
        public NoSuchUserException()
        {
            message = "No such user with the given id";
        }
        public override string Message => message;
        
    }
}