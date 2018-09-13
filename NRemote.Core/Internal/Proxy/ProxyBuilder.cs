using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Reflection;
using Castle.Core.Internal;
using Castle.DynamicProxy;
using log4net;
using NRemote.Commons.Type;

namespace NRemote.Core.Internal.Proxy
{
    internal static partial class ProxyFactory
    {
        /// <summary>
        /// Abstract base class for all proxy builder
        /// </summary>
        /// <typeparam name="TA">Type of used method attribute</typeparam>
        /// <typeparam name="TD">Type of data object for proxy</typeparam>
        private abstract class ProxyBuilder<TA, TD> where TA : Attribute
        {
            private static ILog Logger { get; } = LogManager.GetLogger(typeof(ProxyBuilder<TA,TD>));

            /// <summary>
            /// Creates a new proxy for the given interface. Data of map are returned by getter methods of model.
            /// </summary>
            /// <param name="data"></param>
            /// <typeparam name="T"></typeparam>
            /// <returns></returns>
            public T BuildProxy<T>(TD data)
            {
                Logger.Debug("Create " + ProxyName + " proxy for " + typeof(T).FullName);
                
                Validate(typeof(T));

                return (T) new ProxyGenerator().CreateInterfaceProxyWithoutTarget(typeof(T), new MethodInterceptor((proxy, methodInfo, args) =>
                {
                    Logger.Debug("Call " + ProxyName + " method " + typeof(T).FullName + "#" + methodInfo.Name);

                    var attribute = methodInfo.GetAttribute<TA>();

                    try
                    {
                        return InvokeMethod(attribute, data, typeof(T), methodInfo, args);
                    }
                    catch (Exception e)
                    {
                        Logger.Error("Invocation exception in proxy " + ProxyName + "!", e);
                        throw;
                    }
                }));
            }

            /// <summary>
            /// Run validation for class
            /// </summary>
            /// <param name="type"></param>
            protected abstract void Validate(System.Type type);
            
            /// <summary>
            /// Invoke the method logic
            /// </summary>
            /// <param name="attribute">Found method attribute, see A of class</param>
            /// <param name="data">Data (map) to use for invocation</param>
            /// <param name="type">Type of proxy</param>
            /// <param name="methodInfo">Method to invoke</param>
            /// <param name="args">Args of methods</param>
            /// <returns></returns>
            protected abstract object InvokeMethod(TA attribute, TD data, System.Type type, MethodInfo methodInfo, object[] args);
            
            /// <summary>
            /// Returns the name of proxy (logging only)
            /// </summary>
            protected abstract string ProxyName { get; }
        }
    }
}