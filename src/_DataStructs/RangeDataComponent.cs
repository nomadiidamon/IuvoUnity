
namespace IuvoUniy
{

    namespace _DataStructs
    {
        public struct RangeFloat
        {
            public float min;
            public float max;
            public RangeFloat(float _min, float _max)
            {
                min = _min;
                max = _max;
            }

            public float RandomInRange()
            {
                return UnityEngine.Random.Range(min, max);
            }
        }


    }
}