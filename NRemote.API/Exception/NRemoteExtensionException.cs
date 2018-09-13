namespace NRemote.API.Exception
{
    public abstract class NRemoteExtensionException : NRemoteException
    {
        protected NRemoteExtensionException()
        {
        }

        protected NRemoteExtensionException(string message) : base(message)
        {
        }

        protected NRemoteExtensionException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}