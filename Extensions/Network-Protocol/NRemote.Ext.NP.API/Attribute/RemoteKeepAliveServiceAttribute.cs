using System;
using NRemote.API.Internal;

namespace NRemote.Ext.NP.API.Attribute
{
    /// <summary>
    /// Mark an interface as remote keep alive service. Must have exactly one method: <br/>
    /// <ul>
    /// <li><code>boolean ping(String uuid)</code> annotated with <code><see cref="KeepAliveAttribute"/></code><br/>
    /// Method to ping server with client's UUID to get TRUE if client is registered, otherwise FALSE</li>
    /// </ul>
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface)]
    [RemoteService]
    public class RemoteKeepAliveServiceAttribute : System.Attribute
    {
    }
}