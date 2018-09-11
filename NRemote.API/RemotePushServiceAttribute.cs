using System;
using NRemote.API.Internal;

namespace NRemote.API
{
    /// <summary>
    /// Marker attribute to mark an interface as Push Service
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface)]
    [RemoteService]
    public class RemotePushServiceAttribute : Attribute
    {
        
    }
}