using System.Collections.Generic;
using NRemote.API;

namespace NRemote.Core.Test.Basic.API
{
    [RemotePushModel]
    public interface ITestRemotePushModel
    {
        [PushModelProperty("name")]
        string Name { get; }
        
        [PushModelProperty("value")]
        int Value { get; }
        
        [PushModelProperty("words")]
        IList<string> WordList { get; }
        
        [PushModelProperty("sizes")]
        int[] SizeList { get; }
    }
}