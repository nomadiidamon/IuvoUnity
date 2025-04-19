
namespace IuvoUnity
{
    namespace IuvoECS
    {
        namespace IuvoComponents
        {
            namespace IuvoComponentInterfaces
            {

                public interface IOnAdd
                {
                    public abstract void OnAdd(IuvoEntity.IuvoEntity entity);
                }

                public interface IOnRemove
                {
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

                public interface INotifyOnChange
                {
                    public abstract void Notify(IuvoEntity.IuvoEntity entity);
                }

                public interface IOnActivate
                {
                    public abstract void OnActivate(IuvoEntity.IuvoEntity entity);

                }

                public interface IOnDeactivate
                {
                    public abstract void OnDeactivate(IuvoEntity.IuvoEntity entity);
                }
            }
        }
    }
}