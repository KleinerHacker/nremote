using System;

namespace NRemote.Core.Type
{
    public class StateChangeEventArgs<TS> : EventArgs
    {
        public TS State { get; }

        public StateChangeEventArgs(TS state)
        {
            State = state;
        }
    }
}