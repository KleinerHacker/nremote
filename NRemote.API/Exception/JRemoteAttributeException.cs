namespace NRemote.API.Exception
{
    public class JRemoteAttributeException : JRemoteException
    {
        public JRemoteAttributeException()
        {
        }

        public JRemoteAttributeException(string message) : base(message)
        {
        }

        public JRemoteAttributeException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}