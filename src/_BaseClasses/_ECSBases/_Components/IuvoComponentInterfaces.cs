
namespace IuvoUnity
{
    namespace _ECS
    {
        namespace _Interfaces
        {
    
                public interface ICreate
                {
                    public abstract void OnCreate(IuvoEntity.IuvoEntity entity);
                }
                public interface IDestroy
                {
                    public abstract void OnDestroy(IuvoEntity.IuvoEntity entity);
                }
                public interface ICreatable : ICreate, IDestroy
                {
                    public abstract void Create(IuvoEntity.IuvoEntity entity);
                    public abstract void Destroy(IuvoEntity.IuvoEntity entity);
                }

                public interface IAwake
                {
                    public abstract void OnAwake(IuvoEntity.IuvoEntity entity);
                }
                public interface IInitialize
                {
                    public abstract void Initialize(IuvoEntity.IuvoEntity entity);
                }
                public interface IStart
                {
                    public abstract void OnStart(IuvoEntity.IuvoEntity entity);
                }

                public interface IUpdatable
                {
                    public abstract void Update(IuvoEntity.IuvoEntity entity);
                }
                public interface IUpdate
                {
                    public abstract void OnUpdate(IuvoEntity.IuvoEntity entity);
                }
                public interface IFixedUpdate
                {
                    public abstract void OnFixedUpdate(IuvoEntity.IuvoEntity entity);
                }
                public interface ILateUpdate
                {
                    public abstract void OnLateUpdate(IuvoEntity.IuvoEntity entity);
                }

                public interface IAdd
                {
                    public abstract void OnAdd(IuvoEntity.IuvoEntity entity);
                }
                public interface IRemove
                {
                    public abstract void OnRemove(IuvoEntity.IuvoEntity entity);
                }
                public interface IAddable : IAdd, IRemove
                {
                    public abstract void OnAdd(IuvoEntity.IuvoEntity entity);
                    public abstract void OnRemove(IuvoEntity.IuvoEntity entity);
                }

                public interface IConfigure
                {
                    public abstract void OnConfigure(IuvoEntity.IuvoEntity enity);
                }
                public interface IReconfigure
                {
                    public abstract void OnReconfigure(IuvoEntity.IuvoEntity entity);
                }
                public interface IConfigurable : IConfigure, IReconfigure
                {
                    public abstract void OnConfigure(IuvoEntity.IuvoEntity entity);
                    public abstract void OnReconfigure(IuvoEntity.IuvoEntity entity);
                }

                public interface IChange
                {
                    public abstract void OnChange(IChange change);
                }
                public interface INotifyOfChange
                {
                    public abstract void OnNotifyOfChange<T>(IuvoEntity.IuvoEntity entity);
                }
                public interface INotifiable : INotifyOfChange, IChange
                {
                    public abstract void NotifyOfChange<T>(IuvoEntity.IuvoEntity entity);
                    public abstract void OnChange(IChange change);
                }

                public interface IActivate
                {
                    public abstract void OnActivate(IuvoEntity.IuvoEntity entity);
                }
                public interface IDeactivate
                {
                    public abstract void OnDeactivate(IuvoEntity.IuvoEntity entity);
                }
                public interface IActivatable : IActivate, IDeactivate
                {
                    public abstract void OnActivate(IuvoEntity.IuvoEntity entity);
                    public abstract void OnDeactivate(IuvoEntity.IuvoEntity entity);
                }

                public interface IEnable
                {
                    public abstract void OnEnable(IuvoEntity.IuvoEntity entity);
                }
                public interface IDisable
                {
                    public abstract void OnDisable(IuvoEntity.IuvoEntity entity);
                }
                public interface IEnableable : IEnable, IDisable
                {
                    public abstract void OnEnable(IuvoEntity.IuvoEntity entity);
                    public abstract void OnDisable(IuvoEntity.IuvoEntity entity);
                }

                public interface ITogglable : IEnableable, IActivatable
                {
                    public bool IsEnabled { get; set; }
                    public bool IsActive { get; set; }
                    public abstract void OnEnable(IuvoEntity.IuvoEntity entity);
                    public abstract void OnDisable(IuvoEntity.IuvoEntity entity);
                    public abstract void OnActivate(IuvoEntity.IuvoEntity entity);
                    public abstract void OnDeactivate(IuvoEntity.IuvoEntity entity);
                }
                public interface Pausable : ITogglable
                {
                    public bool IsPaused { get; set; }
                    public abstract void OnPause(IuvoEntity.IuvoEntity entity);
                    public abstract void OnResume(IuvoEntity.IuvoEntity entity);
                }

                public interface IReset
                {
                    public abstract void OnReset(IuvoEntity.IuvoEntity entity);
                }
                public interface IResetData
                {
                    public Type resetData { get; set; }
                }
                public interface IResetable : IReset, IResetData
                {
                    public abstract void OnReset(IuvoEntity.IuvoEntity entity);
                    public Type resetData { get; set; }
                }


                public interface IRegister
                {
                    public abstract void Register(IuvoEntity.IuvoEntity entity);
                }
                public interface IUnregister
                {
                    public abstract void Unregister(IuvoEntity.IuvoEntity entity);
                }
                public interface IRegisterable : IRegister, IUnregister
                {
                    public abstract void Register(IuvoEntity.IuvoEntity entity);
                    public abstract void Unregister(IuvoEntity.IuvoEntity entity);
                }
            
        }
    }
}
