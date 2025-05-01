using UnityEngine;

namespace IuvoUnity
{
    namespace _Interfaces
    {
            public interface IThresholdCondition : IStateACondition
            {
                float GetThresholdValue();
                float GetCurrentValue();
            }

        
    }
}