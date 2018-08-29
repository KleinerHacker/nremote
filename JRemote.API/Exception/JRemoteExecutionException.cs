namespace JRemote.API.Exception
{
    public class JRemoteExecutionException : JRemoteException
    {
        public JRemoteExecutionException()
        {
        }

        public JRemoteExecutionException(string message) : base(message)
        {
        }

        public JRemoteExecutionException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}