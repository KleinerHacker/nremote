using System;
using System.Reflection;
using Castle.Core.Internal;
using Castle.DynamicProxy.Generators;

namespace NRemote.Core.Internal.Validation
{
    internal static partial class Validator
    {
        /// <summary>
        /// Abstract base for a simple variant of the service attribute validator
        /// </summary>
        /// <typeparam name="TC"></typeparam>
        /// <typeparam name="TM"></typeparam>
        private abstract class SimpleAttributeValidator<TC, TM> : AttributeValidator where TC : Attribute where TM : Attribute
        {
            protected override bool ValidateClassAttribute(System.Type type)
            {
                return type.GetAttribute<TC>() != null;
            }

            protected override bool ValidateMethodAttribute(MethodInfo methodInfo)
            {
                return methodInfo.GetAttribute<TM>() != null;
            }
        }
    }
}