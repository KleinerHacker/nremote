using System;

namespace NRemote.API
{
    /// <summary>
    /// Mark a method in an interface as listener method for a event call, see <see cref="RemoteEventServiceAttribute"/>. Interface must be annotated
    /// with <see cref="RemoteEventReceiverAttribute"/>.<br/>
    /// <br/>
    /// The event signature must build as <see cref="EventHandler{TEventArgs}"/> of type <see cref="ReceiverEventArgs{ST}"/>:<br/>
    /// <code>event EventHandler&lt;ReceiverEventArgs&lt;string>> OnLogMessage</code>
    /// </summary>
    [AttributeUsage(AttributeTargets.Event)]
    public class EventReceiverEventAttribute : Attribute
    {
        /// <summary>
        /// The name of this event to receive from <see cref="RemoteEventServiceAttribute"/>, see <see cref="EventAttribute"/>
        /// </summary>
        public string Name { get; set; }

        public EventReceiverEventAttribute(string name)
        {
            Name = name;
        }
    }
}