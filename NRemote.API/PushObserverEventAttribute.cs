using System;

namespace NRemote.API
{
    /// <summary>
    /// Mark a method in an interface as listener method for a push call, see <see cref="RemotePushServiceAttribute"/>. Interface must be annotated
    /// with <see cref="RemotePushObserverAttribute"/>.<br/>
    /// <br/>
    /// The event must build as <see cref="EventHandler"/>:<br/>
    /// <code>event EventHandler NameChanged;</code>
    /// </summary>
    [AttributeUsage(AttributeTargets.Event)]
    public class PushObserverEventAttribute : Attribute
    {
        /// <summary>
        /// The name of the <see cref="RemotePushModelAttribute"/> property the observer listener listen to, see <see cref="PushModelPropertyAttribute.Name"/>
        /// </summary>
        public string Property { get; set; }
        
        /// <summary>
        /// The class of the <see cref="RemotePushModelAttribute"/> within the <see cref="Property"/> the observer listener listen to,
        /// see <see cref="PushModelPropertyAttribute"/>
        /// </summary>
        public System.Type ModelClass { get; set; }

        public PushObserverEventAttribute(string property, System.Type modelClass)
        {
            Property = property;
            ModelClass = modelClass;
        }
    }
}