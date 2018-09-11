using System;

namespace NRemote.API.Internal
{
    /// <summary>
    /// Mark an annotation as remote method annotation
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    internal class RemoteMethodAttribute : Attribute
    {
        
    }
}