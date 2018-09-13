namespace NRemote.API.Exception
{
    public abstract class NRemoteException : System.Exception
    {
        public NRemoteException()
        {
        }

        public NRemoteException(string message) : base(message)
        {
        }

        public NRemoteException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}
