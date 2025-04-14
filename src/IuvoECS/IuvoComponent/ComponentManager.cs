using System;
using System.Collections.Generic;

namespace IuvoUnity
{
    namespace IuvoECS{

        namespace IuvoComponents{

            public class ComponentManager
            {
                public IuvoEntity.IuvoEntity _myIuvoEntity { get; private set; }

                public ComponentManager(IuvoEntity.IuvoEntity myIuvoEntity)
                {
                    _myIuvoEntity = myIuvoEntity;
                }

                private Dictionary<Type, IuvoComponent> _components = new Dictionary<Type, IuvoComponent>();

                public void AddComponent<T>(T component) where T : IuvoComponent
                {
                    _components[typeof(T)] = component;
                    //component.OnAdd(_myIuvoEntity);
                }
#nullable enable
                public T? GetComponent<T>() where T : IuvoComponent
                {
                    if (_components.TryGetValue(typeof(T), out var comp))
                        return comp as T;
                    return null;
                }
#nullable disable
                public bool TryGetComponent<T>(out T component) where T : IuvoComponent
                {
                    if (_components.TryGetValue(typeof(T), out var comp))
                    {
                        component = comp as T;
                        return true;
                    }
                    component = null;
                    return false;
                }

                public bool HasComponent<T>() where T : IuvoComponent
                {
                    return _components.ContainsKey(typeof(T));
                }
                public void RemoveComponent<T>() where T : IuvoComponent
                {
                    if (_components.TryGetValue(typeof(T), out var component))
                    {
                        //component.OnRemove(_myIuvoEntity);
                        _components.Remove(typeof(T));
                    }
                }
                public bool TryToRemoveComponent<T>() where T : IuvoComponent
                {
                    if (!HasComponent<T>()) return false;
                    return _components.Remove(typeof(T));
                }
                public List<IuvoComponent> GetAllComponents()
                {
                    List<IuvoComponent> components = new List<IuvoComponent>();
                    foreach (var component in _components.Values)
                    {
                        components.Add(component);
                    }
                    return components;
                }

                public void ClearComponentManager(IuvoEntity.IuvoEntity entity)
                {
                    foreach (var component in _components.Values)
                    {
                        //component.OnRemove(entity);
                    }
                    _components.Clear();
                }

            }
        }
    }
}

