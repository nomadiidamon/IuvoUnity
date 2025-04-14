using System;

namespace IuvoUnity
{

    public interface IBooleanCondition : IConditional
    {
        bool Evaluate();
    }
}