using System;

namespace IuvoUnity
{
    namespace _Interfaces
    {
        namespace _UtilityInterfaces
        {
            public interface IGenericCondition<T> : IStateACondition
            {
                T GetValue();
                bool Compare(T value);
            }
        }
    }
}