using System;
using System.Collections.Generic;
using System.IO;
using NRemote.Core.Internal.Registry;

namespace NRemote.Core.Internal.Manager
{
    internal sealed class ServerProxyManager
    {
        private readonly IDictionary<System.Type, object> _controlServiceImplDict = new Dictionary<System.Type, object>();
        private readonly IDictionary<System.Type, object> _pushClientProxyDict = new Dictionary<System.Type, object>();
        private readonly IDictionary<System.Type, object> _eventClientProxyDict = new Dictionary<System.Type, object>();
        private object _registrationServiceProxy;
        private object _keepAliveServiceProxy;
        //private readonly IDictionary<System.Type, > TODO: PushModelHandler
        
        //Data
        private readonly ClientRegistry _clientRegistry = new ClientRegistry();

        #region Delegates

        public event EventHandler<ClientRegistrationEventArgs> ClientRegistered
        {
            add => _clientRegistry.ClientRegistered += value;
            remove => _clientRegistry.ClientRegistered -= value;
        }

        public event EventHandler<ClientRegistrationEventArgs> ClientUnregistered
        {
            add => _clientRegistry.ClientUnregistered += value;
            remove => _clientRegistry.ClientUnregistered -= value;
        }

        public Client[] Clients => _clientRegistry.Clients;

        #endregion
    }
}