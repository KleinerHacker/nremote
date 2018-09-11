namespace NRemote.API.Exception
{
    public abstract class JRemoteException : System.Exception
    {
        public JRemoteException()
        {
        }

        public JRemoteException(string message) : base(message)
        {
        }

        public JRemoteException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}
