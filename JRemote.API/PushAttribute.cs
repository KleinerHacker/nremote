using System;
using JRemote.API.Type;

namespace JRemote.API
{
    /// <summary>
    /// Mark method in an interface as push method.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
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