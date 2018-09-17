using Castle.Core.Internal;
using NRemote.Ext.NP.API.Attribute;

namespace NRemote.Core.Internal.Type
{
    internal sealed class RemoteRegistrationClientWrapper : ClientWrapper
    {
        public RemoteRegistrationClientWrapper(object clientProxy) : base(clientProxy)
        {
        }

        public void Register(string uuid, string host, int port)
        {
            FindAndInvokeMethod(
                m => m.GetAttribute<RegistrationAttribute>() != null &&
                     m.GetAttribute<RegistrationAttribute>().Type == RegistrationAttribute.RegistrationType.Register,
                m => m.GetParameters().Length == 3 && m.GetParameters()[0].ParameterType == typeof(string) &&
                     m.GetParameters()[1].ParameterType == typeof(string) && m.GetParameters()[2].ParameterType == typeof(int) &&
                     m.ReturnType == typeof(void),
                uuid, host, port
            );
        }

        public void Unregister(string uuid)
        {
            FindAndInvokeMethod(
                m => m.GetAttribute<RegistrationAttribute>() != null &&
                     m.GetAttribute<RegistrationAttribute>().Type == RegistrationAttribute.RegistrationType.Unregister,
                m => m.GetParameters().Length == 1 && m.GetParameters()[0].ParameterType == typeof(string) &&
                     m.ReturnType == typeof(void),
                uuid
            );
        }
    }
}