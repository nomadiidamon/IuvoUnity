
namespace IuvoUnity
{
    namespace _Interfaces
    {

        public interface IProximityCondition : IStateACondition
        {
            float GetDistance();
            object GetTarget();
        }
    }

}