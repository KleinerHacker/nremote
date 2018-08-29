using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JRemote.API.Exception
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
