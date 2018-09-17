using Castle.Core.Internal;
using NRemote.Ext.NP.API.Attribute;

namespace NRemote.Core.Internal.Type
{
    internal sealed class RemoteKeepAliveClientWrapper : ClientWrapper
    {
        public RemoteKeepAliveClientWrapper(object clientProxy) : base(clientProxy)
        {
        }

        public bool Ping(string uuid)
        {
            return (bool) FindAndInvokeMethod(
                m => m.GetAttribute<KeepAliveAttribute>() != null,
                m => m.GetParameters().Length == 1 && m.GetParameters()[0].ParameterType == typeof(string) &&
                     m.ReturnType == typeof(bool),
                uuid
            );
        }
    }
}