﻿
using IuvoUnity._BaseClasses;
using System;

namespace IuvoUnity
{

    namespace _DataStructs
    {
        public interface ComparableData<T> : IDataStructBase
        {
            bool LessThan(T other);
            bool LessThanOrEqual(T other);
            bool IsEqual(T other);
            bool GreaterThanOrEqual(T other);
            bool GreaterThan(T other);
            bool IsNull();
        }

        public abstract class ComparisonData : ComparableData<ComparisonData>
        { 
            public abstract bool LessThan(ComparisonData other);
            public abstract bool LessThanOrEqual(ComparisonData other);
            public abstract bool IsEqual(ComparisonData other);
            public abstract bool GreaterThanOrEqual(ComparisonData other);
            public abstract bool GreaterThan(ComparisonData other);
            public abstract bool IsNull();
        }

    }
}
