using System;

namespace NRemote.API.Type
{
    public class ReceiverEventArgs : EventArgs
    {
        protected readonly object _value;

        protected ReceiverEventArgs(object value)
        {
            _value = value;
        }
    }
    
    /// <summary>
    /// Event arguments in case of receiving an event of a <see cref="RemoteEventServiceAttribute"/>
    /// </summary>
    /// <typeparam name="T">Type of value</typeparam>
    public class ReceiverEventArgs<T> : ReceiverEventArgs
    {
        /// <summary>
        /// Value that was received
        /// </summary>
        public T Value => (T) _value;

        public ReceiverEventArgs(T value) : base(value)
        {
        }
    }
}