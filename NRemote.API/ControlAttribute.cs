using System;
using NRemote.API.Internal;

namespace NRemote.API
{
    /// <summary>
    /// Annotation to mark a method in a <see cref="RemoteControlServiceAttribute"/> as a control method
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    [RemoteMethod]
    public class ControlAttribute : Attribute
    {
        
    }
}