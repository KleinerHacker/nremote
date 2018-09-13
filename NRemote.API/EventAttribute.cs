using System;
using NRemote.API.Internal;

namespace NRemote.API
{
    /// <summary>
    /// Mark a method in an interface as event method. Interface must be annotated with <see cref="RemoteEventServiceAttribute"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    [RemoteMethod]
    public class EventAttribute : Attribute
    {
        /// <summary>
        /// The name of the event in <see cref="RemoteEventReceiverAttribute"/> to deliver to, see <see cref="EventReceiverEventAttribute.Name"/>
        /// </summary>
        public string Event { get; set; }
        
        /// <summary>
        /// The class of <see cref="RemoteEventReceiverAttribute"/> within the <see cref="Event"/> to deliver to, see <see cref="EventReceiverEventAttribute"/>
        /// </summary>
        public System.Type EventClass { get; set; }

        public EventAttribute(string @event, System.Type eventClass)
        {
            Event = @event;
            EventClass = eventClass;
        }
    }
}