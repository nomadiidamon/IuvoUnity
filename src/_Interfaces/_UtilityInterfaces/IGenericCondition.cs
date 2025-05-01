using System;

namespace IuvoUnity
{
    namespace _Interfaces
    {

            public interface IGenericCondition<T> : IStateACondition
            {
                T GetValue();
                bool Compare(T value);
            }
        
    }
}