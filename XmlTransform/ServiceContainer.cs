using System;
using System.Collections.Generic;

namespace Microsoft.Web.XmlTransform
{
    internal sealed class ServiceContainer : IServiceProvider, IDisposable
    {
        private readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();

        public object GetService(Type serviceType)
        {
            object service;
            _services.TryGetValue(serviceType, out service);
            return service;
        }

        public void Dispose()
        {
            foreach (KeyValuePair<Type, object> pair in _services)
                (pair.Value as IDisposable)?.Dispose();
            _services.Clear();
        }

        public void RemoveService(Type serviceType)
        {
            _services.Remove(serviceType);
        }

        public void AddService(Type serviceType, object service)
        {
            _services.Add(serviceType, service);
        }
    }
}