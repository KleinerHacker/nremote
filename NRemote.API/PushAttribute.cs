using System;
using NRemote.API.Internal;
using NRemote.API.Type;

namespace NRemote.API
{
    /// <summary>
    /// Mark method in an interface as push method. Interface must be marked with <see cref="RemotePushServiceAttribute"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    [RemoteMethod]
    public class PushAttribute : Attribute
    {
        /// <summary>
        /// Target Remote Model Type of pushed value
        /// </summary>
        public System.Type ModelType { get; set; }
        
        /// <summary>
        /// Target property in given Remote Model of pushed value
        /// </summary>
        public String Property { get; set; }

        /// <summary>
        /// Type of push method
        /// </summary>
        public PushMethodType Type { get; set; } = PushMethodType.Default;

        public PushAttribute(System.Type modelType, string property)
        {
            ModelType = modelType;
            Property = property;
        }
    }
}