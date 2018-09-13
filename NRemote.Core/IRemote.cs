using System;
using NRemote.Core.Type;

namespace NRemote.Core
{
    /// <summary>
    /// Remote interface for <see cref="RemoteServer"/> and <see cref="RemoteClient"/> with all common methods
    /// </summary>
    /// <typeparam name="TS"></typeparam>
    public interface IRemote<TS> : IDisposable
    {
        /// <summary>
        /// Open the remote object
        /// </summary>
        void Open();
        /// <summary>
        /// Close the remote object. Is called in <see cref="IDisposable.Dispose"/>, too
        /// </summary>
        void Close();
        
        /// <summary>
        /// Returns the current state of the remote object. This is an other state than <see cref="LifecycleState"/>
        /// </summary>
        TS State { get; }
        event EventHandler<StateChangeEventArgs<TS>> StateChanged;
      
        /// <summary>
        /// Returns the lifecycle state of the remote object
        /// </summary>
        LifecycleState LifecycleState { get; }
        event EventHandler<StateChangeEventArgs<LifecycleState>> LifecycleStateChanged;
        
        /// <summary>
        /// Returns the configured host name of this remote object to use
        /// </summary>
        string Host { get; }
        /// <summary>
        /// Returns the configured port of this remote object to use
        /// </summary>
        int Port { get; }

        /// <summary>
        /// Returns the class of network protocol for this remote instance to use.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetNetworkProtocolClass<T>() where T : TS; //TODO
        /// <summary>
        /// Returns the class of update policy for this remote instance to use.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetUpdatePolicyClass<T>() where T : TS; //TODO
    }
}