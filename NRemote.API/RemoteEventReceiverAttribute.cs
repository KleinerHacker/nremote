using System;
using NRemote.API.Internal;

namespace NRemote.API
{
    /// <summary>
    /// Mark an interface as remote observer for observing data via event methods (<see cref="RemoteEventServiceAttribute"/>),
    /// see <see cref="EventReceiverEventAttribute"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface)]
    [RemoteService]
    public class RemoteEventReceiverAttribute : Attribute
    {
        
    }
}