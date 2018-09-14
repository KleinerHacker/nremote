using System;
using NRemote.API;

namespace NRemote.Core.Test.Basic.API
{
    [RemotePushObserver]
    public interface ITestRemotePushObserver
    {
        [PushObserverEvent("name", typeof(ITestRemotePushModel))]
        event EventHandler NameChanged;

        [PushObserverEvent("value", typeof(ITestRemotePushModel))]
        event EventHandler ValueChanged;

        [PushObserverEvent("words", typeof(ITestRemotePushModel))]
        event EventHandler WordListChanged;

        [PushObserverEvent("sizes", typeof(ITestRemotePushModel))]
        event EventHandler SizeListChanged;
    }
}