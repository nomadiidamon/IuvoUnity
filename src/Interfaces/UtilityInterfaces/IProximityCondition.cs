using UnityEngine;

namespace IuvoUnity {
    public interface IProximityCondition : IStateACondition
    {
        float GetDistance();
        object GetTarget();
    }
}