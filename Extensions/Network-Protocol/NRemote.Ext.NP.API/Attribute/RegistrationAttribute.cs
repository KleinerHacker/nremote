using System;
using NRemote.API.Internal;

namespace NRemote.Ext.NP.API.Attribute
{
    /// <summary>
    /// Marker annotation for an interface method in a remote registration service, see <see cref="RemoteRegistrationServiceAttribute"/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    [RemoteMethod]
    public class RegistrationAttribute : System.Attribute
    {
        /// <summary>
        /// Type of registration method
        /// </summary>
        public RegistrationType Type { get; }

        public RegistrationAttribute(RegistrationType type)
        {
            Type = type;
        }

        /// <summary>
        /// Types of registration actions
        /// </summary>
        public enum RegistrationType
        {
            /// <summary>
            /// Register a client (method with three arguments: UUID (string), host, port)
            /// </summary>
            Register,
            /// <summary>
            /// Unregister a client (method with one argument: UUID (string))
            /// </summary>
            Unregister
        }
    }
}