
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
                    public abstract void NotifyOnChange(IuvoEntity.IuvoEntity entity);
                }
            }
        }
    }
}