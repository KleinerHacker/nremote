using System;

namespace NRemote.API
{
    /// <summary>
    /// Mark a getter method in an interface as model based property. The interface must be annotated with <see cref="RemotePushModelAttribute"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class PushModelPropertyAttribute : Attribute
    {
        /// <summary>
        /// The name of the model property. Used for referencing from <see cref="RemotePushServiceAttribute"/> or <see cref="RemotePushObserverAttribute"/> class,
        /// see <see cref="PushAttribute"/> or <see cref="PushObserverEventAttribute"/>
        /// </summary>
        public string Name { get; set; }

        public PushModelPropertyAttribute(string name)
        {
            Name = name;
        }
    }
}