using IuvoUnity._BaseClasses;
using System;

namespace IuvoUnity
{
    namespace _Interfaces
    {
        public interface ICreate : IuvoInterfaceBase
        {
            public abstract void OnCreate();
        }
        public interface IDestroy : IuvoInterfaceBase
        {
            public abstract void OnDestroy();
        }
        public interface ICreatable : IuvoInterfaceBase, ICreate, IDestroy
        {
            public abstract void Create();
            public abstract void Destroy();
        }

        public interface IAwake : IuvoInterfaceBase
        {
            public abstract void OnAwake();
        }
        public interface IInitialize : IuvoInterfaceBase
        {
            public abstract void Initialize();
        }
        public interface IStart : IuvoInterfaceBase
        {
            public abstract void OnStart();
        }

        public interface IUpdatable : IuvoInterfaceBase
        {
            public abstract void Update();
        }
        public interface IUpdate : IUpdatable
        {
            public abstract void OnUpdate();
        }
        public interface IFixedUpdate : IUpdatable
        {
            public abstract void OnFixedUpdate();
        }
        public interface ILateUpdate : IUpdatable
        {
            public abstract void OnLateUpdate();
        }

        public interface IAdd : IuvoInterfaceBase
        {
            public abstract void OnAdd();
        }
        public interface IRemove : IuvoInterfaceBase
        {
            public abstract void OnRemove();
        }
        public interface IAddable : IuvoInterfaceBase, IAdd, IRemove
        {
        }

        public interface IConfigure : IuvoInterfaceBase
        {
            public abstract void OnConfigure();
        }
        public interface IReconfigure : IuvoInterfaceBase
        {
            public abstract void OnReconfigure();
        }
        public interface IConfigurable : IuvoInterfaceBase, IConfigure, IReconfigure
        {
        }

        public interface IChange : IuvoInterfaceBase
        {
            public abstract void OnChange();
        }
        public interface INotifyOfChange : IuvoInterfaceBase
        {
            public abstract void OnNotifyOfChange<T>() where T : IChange;
        }
        public interface INotifiable : IuvoInterfaceBase, INotifyOfChange, IChange
        {
            public abstract void NotifyOfChange<T>();
        }

        public interface IActivate : IuvoInterfaceBase
        {
            public abstract void Activate();
            public abstract void OnActivate();
        }
        public interface IDeactivate : IuvoInterfaceBase
        {
            public abstract void Deactivate();
            public abstract void OnDeactivate();
        }
        public interface IActivatable : IuvoInterfaceBase, IActivate, IDeactivate
        {
        }

        public interface IEnable : IuvoInterfaceBase
        {
            public abstract void Enable();
            public abstract void OnEnable();
        }
        public interface IDisable : IuvoInterfaceBase
        {
            public abstract void Disable();
            public abstract void OnDisable();
        }
        public interface IEnableable : IuvoInterfaceBase, IEnable, IDisable
        {
        }

        public interface ITogglable : IuvoInterfaceBase, IEnableable, IActivatable
        {
            public bool IsEnabled { get; set; }
            public bool IsActive { get; set; }
        }

        public interface IPausable : IuvoInterfaceBase, ITogglable
        {
            public bool IsPaused { get; set; }
            public abstract void OnPause();
            public abstract void OnResume();
        }

        public interface IReset : IuvoInterfaceBase
        {
            public abstract void OnReset();
        }
        public interface IResetData : IuvoInterfaceBase
        {
           public Type ResetData { get; set; }
        }
        public interface IResetable : IuvoInterfaceBase, IReset, IResetData
        {
        }

        public interface IRegister : IuvoInterfaceBase
        {
            public abstract void Register();
        }
        public interface IUnregister : IuvoInterfaceBase
        {
            public abstract void Unregister();
        }
        public interface IRegisterable : IuvoInterfaceBase, IRegister, IUnregister
        {
        }
    }
}