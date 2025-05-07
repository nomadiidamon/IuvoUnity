using IuvoUnity._BaseClasses._ECS;
using IuvoUnity._BaseClasses._ECS._Interfaces;


namespace IuvoUnity
{
    namespace _ECS
    {
        public abstract class IuvoComponentLayout : IuvoComponentBase, IAddable, IInitialize, IUpdatable
        {
            public virtual void Initialize(IuvoEntity entity) { }
            public virtual void OnAdd(IuvoEntity entity) { }
            public virtual void OnRemove(IuvoEntity entity) { }
            public abstract void Update(IuvoEntity entity);
        }
    }
}