using System;
using NRemote.API.Internal;

namespace NRemote.Ext.NP.API.Attribute
{
    /// <summary>
    /// Marker annotation for an interface method in a remote keep alive service, see <see cref="RemoteKeepAliveServiceAttribute"/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    [RemoteMethod]
    public class KeepAliveAttribute : System.Attribute
    {
    }
}