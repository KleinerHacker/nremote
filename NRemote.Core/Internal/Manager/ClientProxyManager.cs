using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using NRemote.API.Type;
using NRemote.Commons.Type;
using NRemote.Core.Internal.Type;

namespace NRemote.Core.Internal.Manager
{
    internal sealed class ClientProxyManager
    {
        private readonly IDictionary<System.Type, object> _pushModelProxyDict = new Dictionary<System.Type, object>();
        private readonly IDictionary<System.Type, object> _pushObserverProxyDict = new Dictionary<System.Type, object>();
        private readonly IDictionary<System.Type, object> _pushServiceProxyDict = new Dictionary<System.Type, object>();
        private readonly IDictionary<System.Type, object> _eventReceiverProxyDict = new Dictionary<System.Type, object>();
        private readonly IDictionary<System.Type, object> _eventServiceProxyDict = new Dictionary<System.Type, object>();
        private readonly IDictionary<System.Type, object> _controlClientProxyDict = new Dictionary<System.Type, object>();
        private RemoteRegistrationClientWrapper _remoteRegistrationClient;
        private RemoteKeepAliveClientWrapper _remoteKeepAliveClient;
        
        //Data
        private readonly IDictionary<MethodKey, object> _propertyValueDict = new Dictionary<MethodKey, object>();
        private readonly IDictionary<MethodKey, List<EventHandler>> _pushObserverEventDict = new Dictionary<MethodKey, List<EventHandler>>();
        private readonly IDictionary<MethodKey, List<EventHandler<ReceiverEventArgs>>> _eventReceiverEventDict = new Dictionary<MethodKey, List<EventHandler<ReceiverEventArgs>>>();

        #region Push Model Proxy

        public void AddRemotePushModelProxy<T>() where T : class
        {
            var type = typeof(T);
            if (_pushModelProxyDict.ContainsKey(type))
                throw new InvalidOperationException($"Remote push model class already added: {type.FullName}");
            
            //TODO: Build Proxy
        }

        public T GetRemotePushModelProxy<T>()
        {
            var type = typeof(T);
            if (!_pushModelProxyDict.ContainsKey(type))
                throw new InvalidOperationException($"Unknown remote push model class: {type.FullName}");

            return (T) _pushModelProxyDict[type];
        }

        public System.Type[] RemotePushModelClasses => _pushModelProxyDict.Keys.ToArray();

        #endregion
        
        #region Push Observer Proxy

        public void AddRemotePushObserverProxy<T>() where T : class
        {
            var type = typeof(T);
            if (_pushObserverProxyDict.ContainsKey(type))
                throw new InvalidOperationException($"Remote push observer class already added: {type.FullName}");
            
            //TODO: Build Proxy
        }

        public T GetRemotePushObserverProxy<T>()
        {
            var type = typeof(T);
            if (!_pushObserverProxyDict.ContainsKey(type))
                throw new InvalidOperationException($"Unknown remote push observer class: {type.FullName}");

            return (T) _pushObserverProxyDict[type];
        }

        public System.Type[] RemotePushObserverClasses => _pushObserverProxyDict.Keys.ToArray();

        #endregion

        public RemoteRegistrationClientWrapper RemoteRegistrationClient => _remoteRegistrationClient;

        public RemoteKeepAliveClientWrapper RemoteKeepAliveClient => _remoteKeepAliveClient;
    }
}