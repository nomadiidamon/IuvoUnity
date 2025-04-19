using System;

namespace IuvoUnity
{
    namespace _Interfaces
    {
        namespace _UtilityInterfaces
        {
            public interface IBooleanCondition : IConditional
            {
                bool Evaluate();
            }
        }
    }
}