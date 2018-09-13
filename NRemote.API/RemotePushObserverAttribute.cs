using System;

namespace NRemote.API
{
    /// <summary>
    /// Mark an interface as remote observer for observing <see cref="RemotePushModelAttribute"/> via push methods (<see cref="RemotePushServiceAttribute"/>),
    /// see <see cref="PushObserverEventAttribute"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface)]
    public class RemotePushObserverAttribute : Attribute
    {
        
    }
}