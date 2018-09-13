using System;
using NRemote.API.Internal;

namespace NRemote.API
{
    /// <summary>
    /// Mark an interface as remote event service to push data via <see cref="RemotePushObserverAttribute"/>, see <see cref="EventAttribute"/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface)]
    [RemoteService]
    public class RemoteEventServiceAttribute : Attribute
    {
        
    }
}