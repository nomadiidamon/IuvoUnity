using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace IuvoUnity
{
    namespace _ExtensionMethods
    {

        public static class InterfaceExtensions
        {
            public static bool Implements<TInterfface>(this Type type)
            {
                return type is TInterfface;
            }



            public static string[] GetBaseTypes<TInterface>(this TInterface obj)
            {
                var type = typeof(TInterface);
                var baseTypes = new List<string>();
                while (type.BaseType != null)
                {
                    baseTypes.Add(type.BaseType.Name);
                    type = type.BaseType;
                }
                return baseTypes.ToArray();
            }

            public static bool HasMethod<TInterface>(this TInterface obj, string methodName)
            {
                var method = typeof(TInterface).GetMethod(methodName);
                return method != null;
            }

            public static bool HasProperty<TInterface>(this TInterface obj, string propertyName)
            {
                var property = typeof(TInterface).GetProperty(propertyName);
                return property != null;
            }

            public static bool HasField<TInterface>(this TInterface obj, string fieldName)
            {
                var field = typeof(TInterface).GetField(fieldName);
                return field != null;
            }

            public static bool HasEvent<TInterface>(this TInterface obj, string eventName)
            {
                var eventInfo = typeof(TInterface).GetEvent(eventName);
                return eventInfo != null;
            }

            public static bool HasInterface<TInterface>(this TInterface obj, string interfaceName)
            {
                var interfaceType = typeof(TInterface).GetInterface(interfaceName);
                return interfaceType != null;
            }

            public static bool HasAttribute<TInterface>(this TInterface obj, string attributeName)
            {
                var attribute = typeof(TInterface).GetCustomAttributes(true).FirstOrDefault(a => a.GetType().Name == attributeName);
                return attribute != null;
            }

            public static TInterface Clone<TInterface>(this TInterface obj) where TInterface : ICloneable
            {
                return (TInterface)obj.Clone();
            }

            public static TInterface GetDefault<TInterface>()
            {
                return default(TInterface);
            }


            public static bool ImplementsInterface<TInterface>(this Type type)
            {
                return type.GetInterfaces().Contains(typeof(TInterface));
            }



        }
    }
}