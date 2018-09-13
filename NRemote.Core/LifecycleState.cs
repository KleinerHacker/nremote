namespace NRemote.Core
{
    /// <summary>
    /// Represent all lifecycle states of <see cref="RemoteServer"/> and <see cref="RemoteClient"/>
    /// <seealso cref="IRemote{TS}"/>
    /// </summary>
    public enum LifecycleState
    {
        /// <summary>
        /// Instance was created / build, see <see cref="RemoteServerBuilder"/> or <see cref="RemoteClientBuilder"/>
        /// <seealso cref="IRemote{TS}"/>
        /// </summary>
        Created,
        /// <summary>
        /// Instance was opened via <see cref="IRemote{TS}.Open"/>
        /// <seealso cref="IRemote{TS}"/>
        /// </summary>
        Opened,
        /// <summary>
        /// Instance was closed via <see cref="IRemote{TS}.Close"/>
        /// <seealso cref="IRemote{TS}"/>
        /// </summary>
        Closed
    }
}