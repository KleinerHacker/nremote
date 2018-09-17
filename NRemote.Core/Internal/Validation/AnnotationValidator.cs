using System;
using System.Reflection;
using Castle.DynamicProxy.Generators;
using NRemote.API.Exception;

namespace NRemote.Core.Internal.Validation
{
    internal static partial class Validator
    {
        /// <summary>
        /// Abstract base for all service annotation validators
        /// </summary>
        private abstract class AnnotationValidator
        {
            public void Validate<T>() where T : class
            {
                var type = typeof(T);
                if (!type.IsInterface)
                    throw new NRemoteAttributeException($"Unable to use a class as {ServiceName}: {type.FullName}");
                
                if (!ValidateClassAttribute(type))
                    throw new NRemoteAttributeException($"Unable to find {ServiceName} attribute on service interface {type.FullName}");
                
                ValidateClassMethods(type);
            }

            private void ValidateClassMethods(System.Type type)
            {
                foreach (var methodInfo in type.GetMethods())
                {
                    if (!ValidateMethodAttribute(methodInfo))
                        throw new NRemoteAttributeException($"Method {methodInfo.DeclaringType?.FullName}#{methodInfo.Name} has no {ServiceMethodName}");
                }
            }
            
            protected abstract string ServiceName { get; }
            protected abstract string ServiceMethodName { get; }

            /// <summary>
            /// Runs validation for class attribute(s)
            /// </summary>
            /// <param name="type"></param>
            /// <returns></returns>
            protected abstract bool ValidateClassAttribute(System.Type type);
            /// <summary>
            /// Runs validation for method attribute(s)
            /// </summary>
            /// <param name="methodInfo"></param>
            /// <returns></returns>
            protected abstract bool ValidateMethodAttribute(MethodInfo methodInfo);
        }
    }
}