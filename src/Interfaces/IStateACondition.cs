using System;

namespace IuvoUnity
{
    public interface IStateACondition : IBooleanCondition
    {
        bool IsConditionMet();
    }

}