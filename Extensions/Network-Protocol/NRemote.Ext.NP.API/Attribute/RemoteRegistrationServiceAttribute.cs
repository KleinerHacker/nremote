using System;
using NRemote.API.Internal;

namespace NRemote.Ext.NP.API.Attribute
{
    /// <summary>
    /// Mark an interface as remote registration service. Must have exactly two methods: <br/>
    /// <ul>
    /// <li><code>void register(String uuid, String host, int port)</code> marked with <see cref="RegistrationAttribute"/>(<see cref="RegistrationAttribute.RegistrationType.Register"/>)<br/>
    /// Method to register a client, identified by its UUID.</li>
    /// <li><code>void unregister(String uuid)</code> marked with <see cref="RegistrationAttribute"/>(<see cref="RegistrationAttribute.RegistrationType.Unregister"/>)<br/>
    /// Method to unregister a client, identified by its UUID</li>
    /// </ul>
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface)]
    [RemoteService]
    public class RemoteRegistrationServiceAttribute : System.Attribute
    {
    }
}