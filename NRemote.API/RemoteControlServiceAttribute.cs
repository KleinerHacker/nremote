using System;
using NRemote.API.Internal;

namespace NRemote.API
{
    /// <summary>
    /// Mark an interface as remote control service. That controls the server. See <see cref="ControlAttribute"/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface)]
    [RemoteService]
    public class RemoteControlServiceAttribute : Attribute
    {
    }
}