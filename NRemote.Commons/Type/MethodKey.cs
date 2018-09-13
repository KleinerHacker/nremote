using System.IO;

namespace NRemote.Commons.Type
{
    public class MethodKey
    {
        public System.Type Type { get; }
        public string Identifier { get; }

        public MethodKey(System.Type type, string identifier)
        {
            Type = type;
            Identifier = identifier;
        }

        protected bool Equals(MethodKey other)
        {
            return Equals(Type, other.Type) && string.Equals(Identifier, other.Identifier);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((MethodKey) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Type != null ? Type.GetHashCode() : 0) * 397) ^ (Identifier != null ? Identifier.GetHashCode() : 0);
            }
        }

        public string ToString(bool full)
        {
            if (full)
                return $"{nameof(Type)}: {Type}, {nameof(Identifier)}: {Identifier}";

            return Type.FullName + "#" + Identifier;
        }

        public override string ToString()
        {
            return ToString(true);
        }
    }
}