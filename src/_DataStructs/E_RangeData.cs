using IuvoUnity._BaseClasses;
namespace IuvoUnity
{

    namespace _DataStructs
    {
        public interface IRange : IDataStructBases
        {

        }

    






        public struct RangeFloat : IRange
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
        


        public struct RangeDouble : IRange
        {
            public double min;
            public double max;
            public RangeDouble(double _min, double _max)
            {
                min = _min;
                max = _max;
            }
            public double RandomInRange()
            {
                return (double)UnityEngine.Random.Range((float)min, (float)max);
            }
        }



        public class RangeInt : IRange
        {
            public int min;
            public int max;

            public RangeInt(int _min, int _max)
            {
                min = _min;
                max = _max;
            }

            public int RandomInRange()
            {
                return UnityEngine.Random.Range(min, max);
            }


        }




    }
}