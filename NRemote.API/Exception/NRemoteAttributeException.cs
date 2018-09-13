namespace NRemote.API.Exception
{
    public class NRemoteAttributeException : NRemoteException
    {
        public NRemoteAttributeException()
        {
        }

        public NRemoteAttributeException(string message) : base(message)
        {
        }

        public NRemoteAttributeException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}