namespace NRemote.Core
{
    public sealed class Client
    {
        public string Host { get; }
        public int Port { get; }

        public Client(string host, int port)
        {
            Host = host;
            Port = port;
        }

        private bool Equals(Client other)
        {
            return string.Equals(Host, other.Host) && Port == other.Port;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is Client other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Host != null ? Host.GetHashCode() : 0) * 397) ^ Port;
            }
        }

        public override string ToString()
        {
            return $"{nameof(Host)}: {Host}, {nameof(Port)}: {Port}";
        }
    }
}