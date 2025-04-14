using System;

namespace IuvoUnity
{
    public interface IGenericCondition<T> : IStateACondition
    {
        T GetValue();
        bool Compare(T value);
    }
}