using System;

namespace NRemote.API
{
    /// <summary>
    /// Mark an interface as remote model. In it all pushes (<see cref="RemotePushServiceAttribute"/>) are stored in defined properties,
    /// see <see cref="PushModelPropertyAttribute"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface)]
    public class RemotePushModelAttribute : Attribute
    {
        
    }
}