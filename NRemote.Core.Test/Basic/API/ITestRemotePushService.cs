using System.Collections.Generic;
using NRemote.API;
using NRemote.API.Type;

namespace NRemote.Core.Test.Basic.API
{
    [RemotePushService]
    public interface ITestRemotePushService
    {
        [Push("name", typeof(ITestRemotePushModel))]
        void PushName(string name);

        [Push("value", typeof(ITestRemotePushModel))]
        void PushValue(int value);

        [Push("words", typeof(ITestRemotePushModel))]
        void PushAllWords(IList<string> words);

        [Push("words", typeof(ITestRemotePushModel), Type = PushMethodType.SingleListItem)]
        void PushWord(string word, PushItemUpdate update);

        [Push("sizes", typeof(ITestRemotePushModel))]
        void PushAllSizes(int[] sizes);

        [Push("sizes", typeof(ITestRemotePushModel), Type = PushMethodType.SingleListItem)]
        void PushSize(int size, PushItemUpdate update);
    }
}