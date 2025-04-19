using UnityEngine;

namespace IuvoUnity
{
    namespace _Interfaces
    {
        namespace _UtilityInterfaces
        {
            public interface IThresholdCondition : IStateACondition
            {
                float GetThresholdValue();
                float GetCurrentValue();
            }

        }
    }
}