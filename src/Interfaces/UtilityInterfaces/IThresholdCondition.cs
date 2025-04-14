using UnityEngine;

namespace IuvoUnity
{
    public interface IThresholdCondition : IStateACondition
    {
        float GetThresholdValue();
        float GetCurrentValue();
    }

}