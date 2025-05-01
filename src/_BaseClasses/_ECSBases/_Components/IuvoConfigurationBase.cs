using IuvoUnity._BaseClasses._ECS._Interfaces;
namespace IuvoUnity
{
    namespace _BaseClasses
    {
        namespace _ECS
        {
            public abstract class IuvoConfigurationBase : IuvoComponentBase, IConfigurable
            {

                // base class for the configurations of various objects
                public virtual void OnConfigure(IuvoEntity entity) { }
                public virtual void OnReconfigure(IuvoEntity entity) { }
            }
        }
    }
}
