using System;

namespace NRemote.API.Internal
{
    /// <summary>
    /// Mark an annotation as remote service annotation
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    internal class RemoteServiceAttribute : Attribute
    {
        
    }
}