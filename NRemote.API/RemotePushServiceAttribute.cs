using System;
using NRemote.API.Internal;

namespace NRemote.API
{
    /// <summary>
    /// Mark an interface as remote push service to push data into <see cref="RemotePushModelAttribute"/> and <see cref="RemotePushObserverAttribute"/>,
    /// see <see cref="PushAttribute"/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface)]
    [RemoteService]
    public class RemotePushServiceAttribute : Attribute
    {
        
    }
}