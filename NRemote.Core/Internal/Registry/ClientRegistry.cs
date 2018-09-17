using System;
using System.Collections.Generic;
using System.Linq;
using log4net;

namespace NRemote.Core.Internal.Registry
{
    internal sealed class ClientRegistry
    {
        private static ILog Logger { get; } = LogManager.GetLogger(typeof(ClientRegistry));
        
        private readonly IDictionary<string, Client> _clientDict = new Dictionary<string, Client>();

        public event EventHandler<ClientRegistrationEventArgs> ClientRegistered;
        public event EventHandler<ClientRegistrationEventArgs> ClientUnregistered;

        /// <summary>
        /// Register a new client (this client is connected now)
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public void RegisterClient(string uuid, string host, int port)
        {
            Logger.Info($"> Register new client <{uuid}> from {host}:{port}");
            lock (_clientDict)
            {
                if (_clientDict.ContainsKey(uuid))
                    throw new InvalidOperationException($"Client already registered: {uuid}");
                
                var client = new Client(host, port);
                _clientDict.Add(uuid, client);
                ClientRegistered?.Invoke(this, new ClientRegistrationEventArgs(client));
            }
        }

        /// <summary>
        /// Unregister a known client (this client is disconnected now)
        /// </summary>
        /// <param name="uuid"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public void UnregisterClient(string uuid)
        {
            Logger.Info($"> Unregister client <{uuid}>");
            lock (_clientDict)
            {
                if (!_clientDict.ContainsKey(uuid))
                    throw new InvalidOperationException($"Client not registered: {uuid}");
                
                var client = _clientDict[uuid];
                
                _clientDict.Remove(uuid);
                ClientUnregistered?.Invoke(this, new ClientRegistrationEventArgs(client));
            }
        }

        /// <summary>
        /// Returns all known connected clients
        /// </summary>
        public Client[] Clients
        {
            get
            {
                lock (_clientDict)
                {
                    return _clientDict.Values.ToArray();
                }
            }
        }

        /// <summary>
        /// Check that this client is known (also connected)
        /// </summary>
        /// <param name="uuid"></param>
        /// <returns></returns>
        public bool ContainsClient(string uuid)
        {
            lock (_clientDict)
            {
                return _clientDict.ContainsKey(uuid);
            }
        }
    }
    
    public class ClientRegistrationEventArgs : EventArgs
    {
        public Client Client { get; }

        public ClientRegistrationEventArgs(Client client)
        {
            Client = client;
        }
    }
}