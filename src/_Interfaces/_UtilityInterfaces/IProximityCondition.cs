using IuvoUnity._Interfaces._UtilityInterfaces;
using UnityEngine;

namespace IuvoUnity
{
    namespace _Interfaces
    {
        namespace _UtilityInterfaces
        {
            public interface IProximityCondition : IStateACondition
            {
                float GetDistance();
                object GetTarget();
            }
        }
    }
}