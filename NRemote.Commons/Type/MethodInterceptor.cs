using System.Reflection;
using Castle.DynamicProxy;

namespace NRemote.Commons.Type
{
    public class MethodInterceptor : IInterceptor
    {
        private readonly MethodInterceptorDelegate _delegate;

        public MethodInterceptor(MethodInterceptorDelegate @delegate)
        {
            _delegate = @delegate;
        }

        public void Intercept(IInvocation invocation)
        {
            var result = _delegate.Invoke(invocation.Proxy, invocation.Method, invocation.Arguments);
            invocation.ReturnValue = result;
        }
    }

    public delegate object MethodInterceptorDelegate(object proxy, MethodInfo methodInfo, object[] args);
}