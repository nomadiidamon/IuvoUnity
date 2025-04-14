using IuvoUnity.IuvoECS.IuvoComponents;
using System.Collections.Generic;

namespace IuvoUnity
{
    namespace IuvoECS
    {
        namespace IuvoEntity
        {
            public class IuvoEntity
            {
                public int _ID { get; set; }
                public ComponentManager _ComponentManager;
                private IuvoEntity()
                {
                    _ID = 0;
                    _ComponentManager = new ComponentManager(this);
                }

                internal static IuvoEntity CreateFromRegistry()
                {
                    return new IuvoEntity();
                }

                public void AddComponent<T>(T component) where T : IuvoComponent
                {
                    _ComponentManager.AddComponent<T>(component);
                }

#nullable enable
                public T? GetComponent<T>() where T : IuvoComponent
                {
                    return _ComponentManager.GetComponent<T>();
                }
#nullable disable
                public bool HasComponent<T>() where T : IuvoComponent
                {
                    return _ComponentManager.HasComponent<T>();
                }
                public void RemoveComponent<T>() where T : IuvoComponent
                {
                    _ComponentManager.RemoveComponent<T>();
                }
                public void GetAllComponents(out List<IuvoComponent> components)
                {
                    components = _ComponentManager.GetAllComponents();
                }
            }

        }
    }
}