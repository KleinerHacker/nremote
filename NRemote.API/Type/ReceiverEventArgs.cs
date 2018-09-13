using System;

namespace NRemote.API.Type
{
    /// <summary>
    /// Event arguments in case of receiving an event of a <see cref="RemoteEventServiceAttribute"/>
    /// </summary>
    /// <typeparam name="T">Type of value</typeparam>
    public class ReceiverEventArgs<T> : EventArgs
    {
        /// <summary>
        /// Value that was received
        /// </summary>
        public T Value { get; }

        public ReceiverEventArgs(T value)
        {
            Value = value;
        }
    }
}