namespace NRemote.API.Exception
{
    public class NRemoteExecutionException : NRemoteException
    {
        public NRemoteExecutionException()
        {
        }

        public NRemoteExecutionException(string message) : base(message)
        {
        }

        public NRemoteExecutionException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}