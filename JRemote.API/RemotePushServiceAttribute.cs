using System;

namespace JRemote.API
{
    /// <summary>
    /// Marker attribute to mark an interface as Push Service
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface)]
    public class RemotePushServiceAttribute : Attribute
    {
        
    }
}