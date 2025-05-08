
using IuvoUnity._BaseClasses;
using System;

namespace IuvoUnity
{

    namespace _DataStructs
    {
        public interface ComparableData : IDataStructBase
        {
            bool LessThan();
            bool LessThanOrEqual();
            bool Equals();
            bool GreaterThanOrEqual();
            bool GreaterThan();
            bool IsNull();    
        }

        public abstract class ComparisonData : ComparableData 
        { 
            public abstract bool LessThan();
            public abstract bool LessThanOrEqual();
            public abstract bool Equals();
            public abstract bool GreaterThanOrEqual();
            public abstract bool GreaterThan();
            public abstract bool IsNull();
        }

    }
}
