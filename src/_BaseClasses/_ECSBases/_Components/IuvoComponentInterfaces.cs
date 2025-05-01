
using IuvoUnity._BaseClasses;
using System;

namespace IuvoUnity
{
    namespace _BaseClasses {
        namespace _ECS
        {
            namespace _Interfaces
            {
                public interface ICreate : IuvoInterfaceBase
                {
                    public abstract void OnCreate(IuvoEntity entity);
                }
                public interface IDestroy : IuvoInterfaceBase
                {
                    public abstract void OnDestroy(IuvoEntity entity);
                }
                public interface ICreatable : IuvoInterfaceBase, ICreate, IDestroy
                {
                    public abstract void Create(IuvoEntity entity);
                    public abstract void Destroy(IuvoEntity entity);
                }

                public interface IAwake : IuvoInterfaceBase
                {
                    public abstract void OnAwake(IuvoEntity entity);
                }
                public interface IInitialize : IuvoInterfaceBase
                {
                    public abstract void Initialize(IuvoEntity entity);
                }
                public interface IStart : IuvoInterfaceBase
                {
                    public abstract void OnStart(IuvoEntity entity);
                }

                public interface IUpdatable : IuvoInterfaceBase
                {
                    public abstract void Update(IuvoEntity entity);
                }
                public interface IUpdate : IUpdatable
                {
                    public abstract void OnUpdate(IuvoEntity entity);
                }
                public interface IFixedUpdate : IUpdatable
                {
                    public abstract void OnFixedUpdate(IuvoEntity entity);
                }
                public interface ILateUpdate : IUpdatable
                {
                    public abstract void OnLateUpdate(IuvoEntity entity);
                }

                public interface IAdd : IuvoInterfaceBase
                {
                    public abstract void OnAdd(IuvoEntity entity);
                }
                public interface IRemove : IuvoInterfaceBase
                {
                    public abstract void OnRemove(IuvoEntity entity);
                }
                public interface IAddable : IuvoInterfaceBase, IAdd, IRemove
                {

                }

                public interface IConfigure : IuvoInterfaceBase
                {
                    public abstract void OnConfigure(IuvoEntity enity);
                }
                public interface IReconfigure : IuvoInterfaceBase
                {
                    public abstract void OnReconfigure(IuvoEntity entity);
                }
                public interface IConfigurable : IuvoInterfaceBase, IConfigure, IReconfigure
                {

                }

                public interface IChange : IuvoInterfaceBase
                {
                    public abstract void OnChange(IChange change);
                }
                public interface INotifyOfChange : IuvoInterfaceBase
                {
                    public abstract void OnNotifyOfChange<T>(IuvoEntity entity);
                }
                public interface INotifiable : IuvoInterfaceBase, INotifyOfChange, IChange
                {
                    public abstract void NotifyOfChange<T>(IuvoEntity entity);
                }

                public interface IActivate : IuvoInterfaceBase
                {
                    public abstract void OnActivate(IuvoEntity entity);
                }
                public interface IDeactivate : IuvoInterfaceBase
                {
                    public abstract void OnDeactivate(IuvoEntity entity);
                }
                public interface IActivatable : IuvoInterfaceBase, IActivate, IDeactivate
                {

                }

                public interface IEnable : IuvoInterfaceBase
                {
                    public abstract void OnEnable(IuvoEntity entity);
                }
                public interface IDisable : IuvoInterfaceBase
                {
                    public abstract void OnDisable(IuvoEntity entity);
                }
                public interface IEnableable : IuvoInterfaceBase, IEnable, IDisable
                {

                }

                public interface ITogglable : IuvoInterfaceBase, IEnableable, IActivatable
                {
                    public bool IsEnabled { get; set; }
                    public bool IsActive { get; set; }

                }
                public interface Pausable : IuvoInterfaceBase, ITogglable
                {
                    public bool IsPaused { get; set; }
                    public abstract void OnPause(IuvoEntity entity);
                    public abstract void OnResume(IuvoEntity entity);
                }

                public interface IReset : IuvoInterfaceBase
                {
                    public abstract void OnReset(IuvoEntity entity);
                }
                public interface IResetData : IuvoInterfaceBase
                {
                    public Type resetData { get; set; }
                }
                public interface IResetable : IuvoInterfaceBase, IReset, IResetData
                {
                }


                public interface IRegister : IuvoInterfaceBase
                {
                    public abstract void Register(IuvoEntity entity);
                }
                public interface IUnregister : IuvoInterfaceBase
                {
                    public abstract void Unregister(IuvoEntity entity);
                }
                public interface IRegisterable : IuvoInterfaceBase, IRegister, IUnregister
                {
                }

            }
        }
    }
}