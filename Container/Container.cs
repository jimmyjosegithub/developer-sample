using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeveloperSample.Container
{
    public class Container
    {
        private readonly ConcurrentDictionary<Type, Type> types = new ConcurrentDictionary<Type, Type>();
        public void Bind(Type interfaceType, Type implementationType)
        {
            types.TryAdd(interfaceType, implementationType);
        }
        public T Get<T>() 
        {
            var concreteType = types[typeof(T)];
            return (T)Activator.CreateInstance(concreteType);
        }
    }
}