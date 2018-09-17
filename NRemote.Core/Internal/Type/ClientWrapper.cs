using System;
using System.Linq;
using System.Reflection;

namespace NRemote.Core.Internal.Type
{
    /// <summary>
    /// Abstract base class for all client wrappers
    /// </summary>
    internal abstract class ClientWrapper
    {
        protected readonly object _clientProxy;

        protected ClientWrapper(object clientProxy)
        {
            _clientProxy = clientProxy;
        }

        /// <summary>
        /// Find the fit method via method finder function, assert the found function and invoke it.
        /// </summary>
        /// <param name="methodFinder">Finder function to find method to invoke</param>
        /// <param name="assertion">Assertion predicate to assert function signature</param>
        /// <param name="args">Arguments to use for invocation</param>
        /// <returns>Result value of invocation</returns>
        /// <exception cref="InvalidOperationException"></exception>
        protected object FindAndInvokeMethod(Predicate<MethodInfo> methodFinder, Predicate<MethodInfo> assertion, params object[] args)
        {
            var methodInfo = _clientProxy.GetType().GetInterfaces()[0].GetMethods()
                .FirstOrDefault(methodFinder.Invoke);
            if (methodInfo == null)
                throw new InvalidOperationException("Unable to find method in client proxy, see method finder");
            if (!assertion.Invoke(methodInfo))
                throw new InvalidOperationException($"Found method {methodInfo.DeclaringType?.FullName}#{methodInfo.Name}, but with wrong signature");

            return methodInfo.Invoke(_clientProxy, args);
        }
    }
}