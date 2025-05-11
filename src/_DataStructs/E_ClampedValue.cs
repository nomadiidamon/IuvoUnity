using IuvoUnity._BaseClasses;
using System.Collections.Generic;
using UnityEngine;

namespace IuvoUnity
{
    namespace _DataStructs
    {
        [System.Serializable]
        public abstract class ClampedValue<T> : IDataStructBase where T : struct
        {
            public Range<T> Range;

            protected T _value;

            public virtual T Value
            {
                get => _value;
                set => _value = Range.Clamp(value);
            }

            protected ClampedValue(Range<T> range, T initialValue)
            {
                Range = range;
                _value = Range.Clamp(initialValue);
            }

            public bool IsAtMin => EqualityComparer<T>.Default.Equals(_value, Range.Min);
            public bool IsAtMax => EqualityComparer<T>.Default.Equals(_value, Range.Max);
            public bool IsWithinRange => Range.Contains(_value);
        }

        [System.Serializable]
        public class ClampedFloat : ClampedValue<float>
        {
            public ClampedFloat(RangeF range, float initialValue) : base(range, initialValue) { }

            public new RangeF Range
            {
                get => (RangeF)base.Range;
                set => base.Range = value;
            }
        }

        [System.Serializable]
        public class ClampedInt : ClampedValue<int>
        {
            public ClampedInt(RangeInt range, int initialValue) : base(range, initialValue) { }

            public new RangeInt Range
            {
                get => (RangeInt)base.Range;
                set => base.Range = value;
            }
        }
    }
}
